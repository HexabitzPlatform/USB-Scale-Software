using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Globalization;
using System.IO.Ports;
using System.Windows.Forms;
using DOT_NET_COMS_LIB;

namespace USBScaleSoftware
{
    public partial class Form1 : MetroForm
    {

        SerialPort Port;
        uint period, time;
        byte DestinationID, SourceID;
        byte Options = 0x22;
        byte channel = 0x01;
        int Code;
        public byte[] AllBuffer;

        public Form1()
        {
            InitializeComponent();
            baudRateCB.SelectedIndex = 10;
            Port = new SerialPort("COM" + COM.Value, int.Parse(baudRateCB.SelectedItem.ToString()), Parity.None, 8, StopBits.One);
        }

        private void readBTN_Click(object sender, EventArgs e)
        {
            Port.Dispose();
            Port = new SerialPort("COM" + COM.Value, int.Parse(baudRateCB.SelectedItem.ToString()), Parity.None, 8, StopBits.One);
            Code = (int)HexaInterface.Message_Codes.CODE_H26R0_STREAM_PORT_GRAM; // default is gram reading
            switch (unitCB.SelectedItem)
            {
                case "Gram":   Code = (int)HexaInterface.Message_Codes.CODE_H26R0_STREAM_PORT_GRAM; break; 
                case "KG":     Code = (int)HexaInterface.Message_Codes.CODE_H26R0_STREAM_PORT_KGRAM; break;
                case "Ounces": Code = (int)HexaInterface.Message_Codes.CODE_H26R0_STREAM_PORT_OUNCE; break;
                case "Pounds": Code = (int)HexaInterface.Message_Codes.CODE_H26R0_STREAM_PORT_POUND; break;
                default: break;
            }

            try { period = uint.Parse(periodTB.Text); } catch { MetroMessageBox.Show(this, "Check period input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (timeTB.Enabled)
                try { time = uint.Parse(timeTB.Text); } catch { MetroMessageBox.Show(this, "Check time input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            else
                time = 0xFFFFFFFF;    // infinte time code


            byte[] periodBytes = BitConverter.GetBytes(period);
            byte[] timeBytes = BitConverter.GetBytes(time);

            byte modulePort = 0x03;
            byte module = 0x01;

            byte[] Payload = {
                            channel,
                            periodBytes[3],
                            periodBytes[2],
                            periodBytes[1],
                            periodBytes[0],

                            timeBytes[3],
                            timeBytes[2],
                            timeBytes[1],
                            timeBytes[0],

                            modulePort,
                            module};


            HexaInterface HexInter = new HexaInterface(COM.Value.ToString(), int.Parse(baudRateCB.SelectedItem.ToString()));

            //DOT_NET_COMS_LIB.Message Buff = new DOT_NET_COMS_LIB.Message(Destination, Source, Options, Code, Payload);
            //AllBuffer = Buff.GetAll();  // We get the whole buffer bytes to be sent to the Hexabitz modules.

            //try { Port.Open(); } catch { }
            //try { Port.Write(AllBuffer, 0, AllBuffer.Length); } catch { MessageBox.Show("Connection Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            //try { Port.Close(); } catch { }


            HexInter.SendMessage(DestinationID, SourceID, Code, Payload);

            Receive();
        }

        private void ZeroBTN_Click(object sender, EventArgs e)
        {
            Port.Dispose();
            Port = new SerialPort("COM" + COM.Value, int.Parse(baudRateCB.SelectedItem.ToString()), Parity.None, 8, StopBits.One);
            Code = (int)HexaInterface.Message_Codes.CODE_H26R0_ZEROCAL;

            //HexaInterface HexInter = new HexaInterface(COM.Value.ToString());
            byte[] Payload = { channel };

            DOT_NET_COMS_LIB.Message Buff = new DOT_NET_COMS_LIB.Message(DestinationID, SourceID, Options, Code, Payload);
            AllBuffer = Buff.GetAll();  // We get the whole buffer bytes to be sent to the Hexabitz modules.

            try { Port.Open(); } catch { }
            try { Port.Write(AllBuffer, 0, AllBuffer.Length); } catch { MessageBox.Show("Connection Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            try { Port.Close(); } catch { }

            //HexInter.SendMessage(Destination, Source,  Options, Code, Message);
            connectionLBL.Text = "Zero Calibrated";
        }

        private void StopBTN_Click(object sender, EventArgs e)
        {
            Port.Dispose();
            Port = new SerialPort("COM" + COM.Value, int.Parse(baudRateCB.SelectedItem.ToString()), Parity.None, 8, StopBits.One);
            Code = (int)HexaInterface.Message_Codes.CODE_H26R0_STOP;

            HexaInterface HexInter = new HexaInterface(COM.Value.ToString(), int.Parse(baudRateCB.SelectedItem.ToString()));
            byte[] Payload = new byte[0];
            DOT_NET_COMS_LIB.Message Buff = new DOT_NET_COMS_LIB.Message(DestinationID, SourceID, Options, Code, Payload);
            AllBuffer = Buff.GetAll();  // We get the whole buffer bytes to be sent to the Hexabitz modules.

            // Here we call the platform sending protocol.
            // C# Example:
            try { Port.Open(); } catch { }
            try { Port.Write(AllBuffer, 0, AllBuffer.Length); } catch { MessageBox.Show("Connection Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            try { Port.Close(); } catch { }

            //HexInter.SendMessage(Destination, Source, Options, Code, Message);

            sevenSegmentArray1.Value = "STOP";
            connectionLBL.Text = "Stopped";
        }

        // The receiving method to listen to the port if we got any respond from it.
        private void Receive()
        {
            Port.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
            try { Port.Open(); } catch { }
        }

        // Method the .Net platform provide to responed to recieved data from SerialPort.
        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Invoke((MethodInvoker)delegate
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
                //float rounded = (float)(Math.Round(f, 2));

                try
                {
                    if (f != 0)
                    sevenSegmentArray1.Value = string.Format("{0:0.00}", f);
                    connectionLBL.Text = "Receiving...";
                }
                catch
                {
                    connectionLBL.Text = "Error!";
                }
            });
        }

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


        string weight = "";

        private void UnitCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            StopBTN_Click(sender, e);
            weight = unitCB.SelectedItem.ToString();
            weightLBL.Text = weight;
            readBTN_Click(sender, e);
        }

        private void MetroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            if (timeTB.Enabled)
                timeTB.Enabled = false;
            else
                timeTB.Enabled = true;
        }

        private void DestinationID_N_ValueChanged(object sender, EventArgs e)
        {
            DestinationID = (byte)destinationID_N.Value;

        }

        private void SourceID_N_ValueChanged(object sender, EventArgs e)
        {
            SourceID = (byte)sourceID_N.Value;
        }

        private void ChannelToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (channelToggle.Checked)
                channel = 0x01;
            else
                channel = 0x02;
        }
    }
}
