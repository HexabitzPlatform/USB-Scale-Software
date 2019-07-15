using System;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;


namespace ArrayMessaging
{
    public partial class Form1 : Form
    {
        SerialPort port;
        public Form1()
        {
            InitializeComponent();
            port = new SerialPort("COM7", 921600, Parity.None, 8, StopBits.One);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ConnectBTN_Click(object sender, EventArgs e)
        {
            try { port.Open(); } catch { }

            byte length = 0x05;

            byte destination = 0x01;
            byte source = 0x02;
            byte M_C = 0x0A;    //code = 2602 to be represented in two bytes
            byte L_C = 0x2A;
            byte crc = 0x75;


            uint period = uint.Parse(periodTB.Text);
            uint time = uint.Parse(timeTB.Text);


            byte[] buffer = {length, destination, source, M_C, L_C, crc };

            byte[] temp = new byte[1];

            temp[0] = length;

            port.Write(temp, 0, 1);
            Thread.Sleep(1);

            foreach (byte value in buffer)
            {
                temp[0] = value;
                port.Write(temp, 0, 1);
            }
        }


        private void ZeroBTN_Click(object sender, EventArgs e)
        {
            try { port.Open(); } catch { }

            byte length = 0x05;

            byte destination = 0x01;
            byte source = 0x02;
            byte M_C = 0x0A;    //code = 2620 to be represented in two bytes
            byte L_C = 0x3C;
            byte crc = 0x75;
        }

        private void CalibrationBTN_Click(object sender, EventArgs e)
        {
            try { port.Open(); } catch { }

            byte length = 0x05;

            byte destination = 0x01;
            byte source = 0x02;
            byte M_C = 0x0A;    //code = 2621 to be represented in two bytes
            byte L_C = 0x3D;
            byte crc = 0x75;
        }

        private void StartBTN_Click(object sender, EventArgs e)
        {
        }

        private void StopBTN_Click(object sender, EventArgs e)
        {
        }

        private void OpenBTN_Click(object sender, EventArgs e)
        {
            SerialPortProgram();
        }

        private void SerialPortProgram()
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

                uint length_number = uint.Parse(length, System.Globalization.NumberStyles.HexNumber);
                displayLBL.Text = length_number + "";

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
    }
}
