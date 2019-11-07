using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Globalization;
using System.IO.Ports;
using System.Windows.Forms;


namespace USBScaleSoftware
{
    public partial class Form1 : MetroForm
    {
        SerialPort port;

        uint period, time;

        byte destination = 0x01;
        byte source = 0x00;
        byte options = 0x22;
        byte channel = 0x01;
        int code;

        public Form1()
        {
            InitializeComponent();
            port = new SerialPort("COM" + COM.Value, 921600, Parity.None, 8, StopBits.One);
        }

        private void readBTN_Click(object sender, EventArgs e)
        {
            port.Dispose();
            port = new SerialPort("COM" + COM.Value, 921600, Parity.None, 8, StopBits.One);
            code = (int)HexaInterface.MSG_Codes.CODE_H26R0_STREAM_PORT_GRAM; // default is gram reading
            switch (unitCB.SelectedItem)
            {
                case "Gram":   code = (int)HexaInterface.MSG_Codes.CODE_H26R0_STREAM_PORT_GRAM; break; 
                case "Kg":     code = (int)HexaInterface.MSG_Codes.CODE_H26R0_STREAM_PORT_KGRAM; break;
                case "Ounces": code = (int)HexaInterface.MSG_Codes.CODE_H26R0_STREAM_PORT_OUNCE; break;
                case "Pounds": code = (int)HexaInterface.MSG_Codes.CODE_H26R0_STREAM_PORT_POUND; break;
                default: break;
            }

            byte modulePort = 0x03;
            byte module = 0x01;


            try { period = uint.Parse(periodTB.Text); } catch { MetroMessageBox.Show(this, "Check period input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (timeTB.Enabled)
                try { time = uint.Parse(timeTB.Text); } catch { MetroMessageBox.Show(this, "Check time input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            else
                time = 0xFFFFFFFF;    // infinte time code


            byte[] periodBytes = BitConverter.GetBytes(period);
            byte[] timeBytes = BitConverter.GetBytes(time);

            byte[] Message = {
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


            HexaInterface HexInter = new HexaInterface(COM.Value.ToString());
            HexInter.SendMessage(destination, source, options, code, Message);
            
            receive();
        }

        private void ZeroBTN_Click(object sender, EventArgs e)
        {
            code = (int)HexaInterface.MSG_Codes.CODE_H26R0_ZEROCAL;

            HexaInterface HexInter = new HexaInterface(COM.Value.ToString());
            byte[] Message = { channel };
            HexInter.SendMessage(destination, source,  options, code, Message);
            connectionLBL.Text = "Zero Calbirated";
        }

        private void StopBTN_Click(object sender, EventArgs e)
        {
            code = (int)HexaInterface.MSG_Codes.CODE_H26R0_STOP;

            HexaInterface HexInter = new HexaInterface(COM.Value.ToString());
            byte[] Message = new byte[0];
            HexInter.SendMessage(destination, source, options, code, Message);
            
            sevenSegmentArray1.Value = "STOP";
            connectionLBL.Text = "Stopped";
        }

        private void receive()
        {
            port.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
            try { port.Open(); } catch { }
        }

        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Invoke((MethodInvoker)delegate
            {
                int bytes_count = 0;
                byte[] buffer = new byte[4];
                bytes_count = port.Read(buffer, 0, 4);

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

                try
                {
                    sevenSegmentArray1.Value = rounded + "";
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
            //readBTN_Click(sender, e);
        }

        private void MetroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            if (timeTB.Enabled)
                timeTB.Enabled = false;
            else
                timeTB.Enabled = true;
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
