using System.Collections.Generic;
using System.IO.Ports;

namespace USBScaleSoftware
{
    class HexabitzModulesConnector
    {
        SerialPort port;
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

        public void SendMessage(byte M_C, byte L_C, byte channel, byte [] data, string COM)
        {
            port = new SerialPort("COM" + COM, 921600, Parity.None, 8, StopBits.One);

            length = (byte)(data.Length - 4);

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
            fullBfferList.Add(modulePort);
            fullBfferList.Add(module);

        }

    }
}
