namespace USBScaleSoftware
{
    class Buffer
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


        protected uint CRC32B(byte[] Buffer)
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
            return CRC;
        }
    }
}
