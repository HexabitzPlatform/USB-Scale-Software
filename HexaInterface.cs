using System.IO.Ports;
using System.Windows.Forms;

namespace USBScaleSoftware
{
    class HexaInterface
    {
        string COM;
        public HexaInterface(string COM)
        {
            this.COM = COM;
        }

        // Method to send the buffer to Hexabitz modules
        public void SendMessage(byte Source, byte Destination, byte Options, int Code, byte[] Message)
        {
            Buffer Buffer = new Buffer(Source, Destination, Options, Code, Message);
            
            // Here we call the platform sending protocols.
            // C# Example:
            SerialPort Port = new SerialPort("COM" + COM, 921600, Parity.None, 8, StopBits.One);
            try { Port.Open(); } catch { }
            try { Port.Write(FullBuffer, 0, FullBuffer.Length); } catch { MessageBox.Show("Connection Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            try { Port.Close(); } catch { }
        }
    }
}
