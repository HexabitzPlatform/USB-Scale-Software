using System.Collections.Generic;

namespace USBScaleSoftware
{
    class Buffer
    {
        #region Buffer Variables
        public byte H = 0x48,
             Z = 0x5A,
             Length,
             Destination,
             Source,
             Options,
             LC,     // Least significate code byte.
             MC,     // Most significate code byte.
             Channel,
             // Message byte array 
             // ...
             ModulePort,
             Module,
             CRC;
        public byte[] Message, AllBuffer, OrganizedBuffer;
        #endregion

        // Main Constructor
        // If there is no Message or ModulePort initialize the message with new byte[0] & ModulePort = 0 & Module = 0. 
        public Buffer (byte Destination, byte Source, byte Options, int Code, byte Channel, byte[] Message, byte ModulePort, byte Module)
        {
            if (ModulePort != 0)
                Length = (byte)(12 + Message.Length - 4);
            else
                if (Channel != 3)
                Length = (byte)(10 + Message.Length - 4); // Without ModulePort & Module.
            else
                Length = (byte)(9 + Message.Length - 4);

            this.Destination = Destination;
            this.Source = Source;
            this.Options = Options;
            LC = (byte)(Code & 0xFF); // Get the MC & LC automaticly from the code.
            MC = (byte)(Code >> 8);
            this.Channel = Channel;
            this.Message = Message;

            this.ModulePort = ModulePort;
            this.Module = Module;
            CRC = GetCRC();
            AllBuffer = GetAll();
        }
        public Buffer(byte Source, byte Destination, byte Options, int Code, byte[] Message)
        {
            this.Destination = Destination;
            this.Source = Source;
            this.Options = Options;
            LC = (byte)(Code & 0xFF); // Get the MC & LC automaticly from the code.
            MC = (byte)(Code >> 8);
            this.Message = Message;
        }


        // Return the Cyclic Redundancy Check for the buffer
        public byte GetCRC()
        {
            List<byte> BufferList = new List<byte>();
            BufferList.Add(H);
            BufferList.Add(Z);
            BufferList.Add(Length);
            BufferList.Add(Destination);
            BufferList.Add(Source);
            BufferList.Add(Options);
            BufferList.Add(LC);
            BufferList.Add(MC);
            BufferList.Add(Channel);

            foreach (byte item in Message)
            {
                BufferList.Add(item);
            }
            if (ModulePort != 0)
            {
                BufferList.Add(ModulePort);
                BufferList.Add(Module);
            }

            List<byte> organizedBufferList = Organize(BufferList); // Here we are organizing the buffer to calculate the CRC for it.
            OrganizedBuffer = organizedBufferList.ToArray();
            CRC = CRC32B(OrganizedBuffer);

            return CRC;
        }

        // Get the whole buffer 
        public byte[] GetAll()
        {
            List<byte> BufferList = new List<byte>();
            BufferList.Add(H);
            BufferList.Add(Z);
            BufferList.Add(Length);
            BufferList.Add(Destination);
            BufferList.Add(Source);
            BufferList.Add(Options);
            BufferList.Add(LC);
            BufferList.Add(MC);
            BufferList.Add(Channel);

            foreach (byte item in Message)
            {
                BufferList.Add(item);
            }
            if (ModulePort != 0)
            {
                BufferList.Add(ModulePort);
                BufferList.Add(Module);
            }
            BufferList.Add(CRC);

            AllBuffer = BufferList.ToArray();

            return AllBuffer;
        }

        // Routin for ordering the buffer to calculate the CRC for it.
        private List<byte> Organize(List<byte> list) 
        {
            List<byte> OrganizedList = new List<byte>();

            int MultiplesOf4 = 0;

            List<byte> temp = new List<byte>();
            foreach (byte item in list)
            {
                temp.Add(item);
                if (temp.Count == 4)
                {
                    MultiplesOf4++;
                    temp.Reverse();
                    foreach (byte itemReversed in temp)
                    {
                        OrganizedList.Add(itemReversed);
                    }
                    temp.Clear();
                }
            }
            temp.Clear();
            if ((list.Count - OrganizedList.Count) != 0)
            {
                int startingItem = MultiplesOf4 * 4;
                for (int i = startingItem; i < list.Count; i++)
                {
                    temp.Add(list[i]);
                }

                while (temp.Count < 4)
                    temp.Add(0);
                temp.Reverse();

                foreach (byte value in temp)
                {
                    OrganizedList.Add(value);
                }
            }
            return OrganizedList;
        }

        // Algorithm used in the Hexabitz modules hardware to calculate the correct CRC32 but we are only using the first byte in our modules. 
        private byte CRC32B(byte[] Buffer)  // Change byte to int to get the whole CRC32.
        {
            byte L = (byte)Buffer.Length;
            byte I, J;
            uint CRC, MSB;
            CRC = 0xFFFFFFFF;
            for (I = 0; I < L; I++)
            {
                CRC ^= (((uint)Buffer[I]) << 24);
                for (J = 0; J < 8; J++)
                {
                    MSB = CRC >> 31;
                    CRC <<= 1;
                    CRC ^= (0 - MSB) & 0x04C11DB7;
                }
            }
            return (byte)CRC; // Remove (byte) to get get the full int.
        }

        

        // Enum for the codes to be sent to the modules
        public enum MSG_Codes
        {
            // H26R0x
            CODE_H26R0_SET_RATE = 1900,
            CODE_H26R0_STREAM_PORT_GRAM = 1901,
            CODE_H26R0_STREAM_PORT_KGRAM = 1902,
            CODE_H26R0_STREAM_PORT_OUNCE = 1903,
            CODE_H26R0_STREAM_PORT_POUND = 1904,
            CODE_H26R0_STOP = 1905,
            CODE_H26R0_SAMPLE_GRAM = 1906,
            CODE_H26R0_SAMPLE_KGRAM = 1907,
            CODE_H26R0_SAMPLE_OUNCE = 1908,
            CODE_H26R0_SAMPLE_POUND = 1909,
            CODE_H26R0_ZEROCAL = 1910,
        }
    }
}
