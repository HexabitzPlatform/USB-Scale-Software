using System.Collections.Generic;
using System.IO.Ports;

namespace USBScaleSoftware
{
    class HexabitzModulesConnector
    {
        byte H = 0x48,
             Z = 0x5A,
             length,
             destination = 0x01,
             source = 0x00,
             options = 0x22,
             channel,

             modulePort,
             module,
             CRC;
        
        ///<summary>
        ///Sending data to module
        ///<para>COM: COM number to connect with</para>
        ///<para>M_C: The Most significant byte of code</para>
        ///<para>L_C: The Least significant byte of code</para>
        ///<para>channel: The channel to connect with</para>
        ///<para>data: the message to be sent to the module</para>
        ///</summary>
        public void SendMessage(string COM, byte M_C, byte L_C, byte channel, byte [] data)
        {
            length = 6;

            List<byte> fullBfferList = new List<byte>
            {
                H,
                Z,
                length,
                destination,
                source,
                options,
                L_C,
                M_C,
                channel
            };
            foreach (byte item in data)
            {
                fullBfferList.Add(item);
            }
            //fullBfferList.Add(modulePort);
            //fullBfferList.Add(module);

            List<byte> organizedBufferList = Organize(fullBfferList); // here we are organizing the buffer to calculate the CRC for it
            byte[] organizedBuffer = organizedBufferList.ToArray();
            uint crc32b_val = Crc32b(organizedBuffer);
            byte CRC32 = (byte)crc32b_val;

        }
        private List<byte> Organize(List<byte> list) // Routin for ordering the buffer to calculate the CRC32 for it
        {
            List<byte> organizedList = new List<byte>();

            int multiplesOf4 = 0;

            List<byte> temp = new List<byte>();
            foreach (byte item in list)
            {
                temp.Add(item);
                if (temp.Count == 4)
                {
                    multiplesOf4++;
                    temp.Reverse();
                    foreach (byte itemReversed in temp)
                    {
                        organizedList.Add(itemReversed);
                    }
                    temp.Clear();
                }
            }
            temp.Clear();
            if ((list.Count - organizedList.Count) != 0)
            {
                int startingItem = multiplesOf4 * 4;
                for (int i = startingItem; i < list.Count; i++)
                {
                    temp.Add(list[i]);
                }

                while (temp.Count < 4)
                    temp.Add(0);
                temp.Reverse();

                foreach (byte value in temp)
                {
                    organizedList.Add(value);
                }
            }

            return organizedList;
        }

        private uint Crc32b(byte[] message)
        {
            byte l = (byte)message.Length;
            byte i, j;
            uint crc, msb;

            crc = 0xFFFFFFFF;
            for (i = 0; i < l; i++)
            {
                // xor next byte to upper bits of crc
                crc ^= (((uint)message[i]) << 24);
                for (j = 0; j < 8; j++)
                {    // Do eight times.
                    msb = crc >> 31;
                    crc <<= 1;
                    crc ^= (0 - msb) & 0x04C11DB7;
                }
            }
            return crc;
        }
    }
}
