using System;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;


namespace ArrayMessaging
{
    public partial class Form1 : Form
    {
        SerialPort port;

        uint period, time;
        public Form1()
        {
            InitializeComponent();
            port = new SerialPort("COM7", 921600, Parity.None, 8, StopBits.One);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void readBTN_Click(object sender, EventArgs e)
        {
            port.Dispose();
            port = new SerialPort("COM7", 921600, Parity.None, 8, StopBits.One);

            byte length = 0x10;

            byte destination = 0x01;
            byte source = 0x00;
            byte M_C = 0x0A;    //code = 2601 to be represented in two bytes
            byte L_C = 0x29;
            byte channel = 0x01;
            byte module = 0x02;
            byte modulePort = 0x06;
            byte crc = 0x75;

            try { period = uint.Parse(periodTB.Text); } catch { MessageBox.Show("Check period input!"); return; }
            try { time = uint.Parse(timeTB.Text); } catch { MessageBox.Show("Check time input!"); return; }

            if (radioButton2.Checked)
                channel = 0x02;
            else
                channel = 0x01;

            byte[] periodBytes = BitConverter.GetBytes(period);
            byte[] timeBytes = BitConverter.GetBytes(time);

            byte[] buffer = {destination,
                            source,
                            M_C,
                            L_C,
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
                            module,
                            crc};

            try { port.Open(); } catch { }

            byte[] temp = new byte[1];
            temp[0] = length;
            port.Write(temp, 0, 1);

            Thread.Sleep(1);

            port.Write(buffer, 0, 16);

            receive();
        }

        private void ReadKGBTN_Click(object sender, EventArgs e)
        {
            byte length = 0x10;

            byte destination = 0x01;
            byte source = 0x00;
            byte M_C = 0x0A;    //code = 2601 to be represented in two bytes
            byte L_C = 0x2A;
            byte channel = 0x01;
            byte module = 0x02;
            byte modulePort = 0x06;
            byte crc = 0x75;

            period = uint.Parse(periodTB.Text);
            time = uint.Parse(timeTB.Text);

            if (radioButton2.Checked)
                channel = 0x02;

            byte[] periodBytes = BitConverter.GetBytes(period);
            byte[] timeBytes = BitConverter.GetBytes(time);

            byte[] buffer = {destination,
                            source,
                            M_C,
                            L_C,
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
                            module,
                            crc};

            try { port.Open(); } catch { }

            byte[] temp = new byte[1];
            temp[0] = length;
            port.Write(temp, 0, 1);

            Thread.Sleep(1);

            port.Write(buffer, 0, 16);

            receive();
        }

        private void ZeroBTN_Click(object sender, EventArgs e)
        {
            byte length = 0x06;

            byte destination = 0x01;
            byte source = 0x00;
            byte M_C = 0x0A;    //code = 2610 to be represented in two bytes
            byte L_C = 0x32;
            byte channel = 0x01;
            byte crc = 0x75;

            try { port.Open(); } catch { }

            byte[] temp = new byte[1];
            temp[0] = length;
            port.Write(temp, 0, 1);

            Thread.Sleep(1);

            byte[] buffer = {destination,
                            source,
                            M_C,
                            L_C,
                            channel,
                            crc};

            port.Write(buffer, 0, 6);
            displayLBL.Text = "00000";
            testBufferTB.Clear();
        }

        private void StopBTN_Click(object sender, EventArgs e)
        {
            try { port.Close(); } catch { };
            byte length = 0x05;

            byte destination = 0x01;
            byte source = 0x00;
            byte M_C = 0x0A;    //code = 2605 to be represented in two bytes
            byte L_C = 0x2D;
            byte crc = 0x75;

            try { port.Open(); } catch { }

            byte[] temp = new byte[1];
            temp[0] = length;
            port.Write(temp, 0, 1);

            Thread.Sleep(1);

            byte[] buffer = {destination,
                            source,
                            M_C,
                            L_C,
                            crc};

            port.Write(buffer, 0, 5);

            try { port.Close(); } catch { };
            sevenSegmentArray1.Value = "STOPED";
            connectionLBL.Text = "Stopped";
            port.Dispose();
            port = new SerialPort("COM7", 921600, Parity.None, 8, StopBits.One);

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

                string D0 = to_right_hex(buffer[0].ToString("X"));
                string D1 = to_right_hex(buffer[1].ToString("X"));
                string D2 = to_right_hex(buffer[2].ToString("X"));
                string D3 = to_right_hex(buffer[3].ToString("X"));
                string length = D3 + D2 + D1 + D0;

                try
                {

                    uint length_number = uint.Parse(length, System.Globalization.NumberStyles.HexNumber);
                    if (KGRB.Checked)
                        length_number /= 1000;
                    displayLBL.Text = length_number + "";
                    sevenSegmentArray1.Value = length_number + "";
                    connectionLBL.Text = "Receiving...";
                }
                catch
                {
                    displayLBL.Text = "Error";
                    connectionLBL.Text = "Error!";
                }

                testBufferTB.Text += "Total bytes: " + bytes_count + "\n";
                string final_string = "";


                foreach (byte value in buffer)
                {
                    final_string += value + "\n";
                }
                testBufferTB.Text = final_string;
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

        private void IfnCB_CheckedChanged(object sender, EventArgs e)
        {
            if (timeTB.Enabled)
            {
                timeTB.Enabled = false;
                time = 0xFFFFFFFF;
            }
            else
                timeTB.Enabled = true;
                
        }
    }
}
