using System.Collections.Generic;

namespace USBScaleSoftware
{
    class Buffer
    {
        #region Variables
        public byte H = 0x48,
             Z = 0x5A,
             Length = 0,
             Destination,
             Source,
             Options,
             LSC,     // Least significance code byte.
             MSC,     // Most significance code byte.
             // Message byte array 
             // ...
             CRC;
        List<byte> AllBufferList;
        byte[] Message, AllBuffer, OrganizedBuffer;
        #endregion

        /// <summary>
        /// The Hexabitz Buffer class wiki: https://hexabitz.com/docs/code-overview/array-messaging/
        /// The general constructor, all the payload parameters [Par1, Par2,...] must be included in the correct order within the Message array.
        /// </summary>
        public Buffer(byte Destination, byte Source,  byte Options, int Code, byte[] Message)
        {
            this.Destination = Destination;
            this.Source = Source;
            this.Options = Options;
            LSC = (byte)(Code & 0xFF); // Get the MSC & LSC automaticly from the code.
            MSC = (byte)(Code >> 8);
            this.Message = Message;

            AllBufferList = new List<byte>();
            AllBufferList.Add(H);
            AllBufferList.Add(Z);
            AllBufferList.Add(Length);
            AllBufferList.Add(Destination);
            AllBufferList.Add(Source);
            AllBufferList.Add(Options);
            AllBufferList.Add(LSC);
            if(MSC != 0) // If the code is only one byte so the MSC
                AllBufferList.Add(MSC);

            foreach (byte item in Message)
            {
                AllBufferList.Add(item);
            }

            Length = (byte)(AllBufferList.Count - 3); // Not including H & Z delimiters, the length byte itself and the CRC byte
                                                      // so its 4 but we didn't add the CRC yet so its 3.
            AllBufferList[2] = Length; // Replace it with the correct length value.
            CRC = GetCRC();
            AllBufferList.Add(CRC);
            AllBuffer = AllBufferList.ToArray();
        }

        // Return the Cyclic Redundancy Check for the buffer.
        public byte GetCRC()
        {
            List<byte> organizedBufferList = Organize(AllBufferList); // Here we are organizing the buffer to calculate the CRC for it.
            OrganizedBuffer = organizedBufferList.ToArray();
            CRC = CRC32B(OrganizedBuffer);
            return CRC;
        }

        // Get the whole buffer.
        public byte[] GetAll()
        {
            return AllBuffer;
        }

        // Routin for ordering the buffer to calculate the CRC for it.
        private List<byte> Organize(List<byte> BufferList) 
        {
            List<byte> OrganizedBuffer = new List<byte>();

            int MultiplesOf4 = 0;

            List<byte> temp = new List<byte>();
            foreach (byte item in BufferList)
            {
                temp.Add(item);
                if (temp.Count == 4)
                {
                    MultiplesOf4++;
                    temp.Reverse();
                    foreach (byte itemReversed in temp)
                    {
                        OrganizedBuffer.Add(itemReversed);
                    }
                    temp.Clear();
                }
            }
            temp.Clear();
            if ((BufferList.Count - OrganizedBuffer.Count) != 0)
            {
                int startingItem = MultiplesOf4 * 4;
                for (int i = startingItem; i < BufferList.Count; i++)
                {
                    temp.Add(BufferList[i]);
                }

                while (temp.Count < 4)
                    temp.Add(0);
                temp.Reverse();

                foreach (byte value in temp)
                {
                    OrganizedBuffer.Add(value);
                }
            }
            return OrganizedBuffer;
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
    }
}
