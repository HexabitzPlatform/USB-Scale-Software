using System;
using System.Globalization;
using System.IO.Ports;
using System.Windows.Forms;

namespace USBScaleSoftware
{
    class HexaInterface
    {
        SerialPort Port;
        string COM;
        public byte[] AllBuffer;
        public HexaInterface(string COM)
        {
            this.COM = COM;
        }

        public void Start()
        {
            Port = new SerialPort("COM" + COM, 921600, Parity.None, 8, StopBits.One); // The default values to be used in the connection.
            try { Port.Open(); } catch { }
        }

        public void End()
        {
            try { Port.Close(); } catch { }
            Port.Dispose();
        }

        // Method to send the buffer to Hexabitz modules.
        public void SendMessage(byte Destination, byte Source, byte Options, int Code, byte[] Message)
        {
            Start();
            Buffer Buff = new Buffer(Destination, Source, Options, Code, Message);
            AllBuffer = Buff.GetAll();  // We get the whole buffer bytes to be sent to the Hexabitz modules.
            
            // Here we call the platform sending protocol.
            // C# Example:
            try { Port.Open(); } catch { }
            try { Port.Write(AllBuffer, 0, AllBuffer.Length); } catch { MessageBox.Show("Connection Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            try { Port.Close(); } catch { }
            End();
        }

        // The reviceing method to listen to the port if we got any respond from it.
        private void receive()
        {
            Port.DataReceived += new SerialDataReceivedEventHandler(Port_DataReceived);
            try { Port.Open(); } catch { }
        }

        // Method the .Net platform provide to responed to recieved data from SerialPort.
        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int bytes_count = 0;
            byte[] buffer = new byte[4];
            bytes_count = Port.Read(buffer, 0, 4);

            string D0 = to_right_hex(buffer[3].ToString("X"));
            string D1 = to_right_hex(buffer[2].ToString("X"));
            string D2 = to_right_hex(buffer[1].ToString("X"));
            string D3 = to_right_hex(buffer[0].ToString("X"));
            string weight = D3 + D2 + D1 + D0;

            int IntRep = int.Parse(weight, NumberStyles.AllowHexSpecifier);
            float f = BitConverter.ToSingle(BitConverter.GetBytes(IntRep), 0);
            float rounded = (float)(Math.Round(f, 2));
            if (rounded < 0.1f)
                rounded = 0;
        }

        // To correct the values recieved from the port.
        private string to_right_hex(string hex)
        {
            switch (hex)
            {
                case "A": hex = "0" + hex; break;
                case "B": hex = "0" + hex; break;
                case "C": hex = "0" + hex; break;
                case "D": hex = "0" + hex; break;
                case "E": hex = "0" + hex; break;
                case "F": hex = "0" + hex; break;
            }
            return hex;
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
