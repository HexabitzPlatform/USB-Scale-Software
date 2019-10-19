namespace USBScaleSoftware
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.COM = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.sevenSegmentArray1 = new DmitryBrant.CustomControls.SevenSegmentArray();
            this.connectionLBL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.metroToggle1 = new MetroFramework.Controls.MetroToggle();
            this.readBTN = new MetroFramework.Controls.MetroButton();
            this.zeroBTN = new MetroFramework.Controls.MetroButton();
            this.stopBTN = new MetroFramework.Controls.MetroButton();
            this.unitCB = new MetroFramework.Controls.MetroComboBox();
            this.periodTB = new MetroFramework.Controls.MetroTextBox();
            this.timeTB = new MetroFramework.Controls.MetroTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.channelToggle = new MetroFramework.Controls.MetroToggle();
            this.weightLBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.COM)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::USBScaleSoftware.Properties.Resources.colored_horizontal;
            this.pictureBox1.Location = new System.Drawing.Point(818, 588);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(734, 604);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 48;
            this.label5.Text = "Powerd by ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(347, 609);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 29);
            this.label4.TabIndex = 47;
            this.label4.Text = "COM";
            // 
            // COM
            // 
            this.COM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.COM.Location = new System.Drawing.Point(422, 606);
            this.COM.Name = "COM";
            this.COM.Size = new System.Drawing.Size(60, 36);
            this.COM.TabIndex = 46;
            this.COM.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(117, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 29);
            this.label3.TabIndex = 45;
            this.label3.Text = "Weight Unit:";
            // 
            // sevenSegmentArray1
            // 
            this.sevenSegmentArray1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sevenSegmentArray1.ArrayCount = 8;
            this.sevenSegmentArray1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sevenSegmentArray1.ColorBackground = System.Drawing.SystemColors.Control;
            this.sevenSegmentArray1.ColorDark = System.Drawing.SystemColors.Control;
            this.sevenSegmentArray1.ColorLight = System.Drawing.Color.Red;
            this.sevenSegmentArray1.DecimalShow = true;
            this.sevenSegmentArray1.ElementPadding = new System.Windows.Forms.Padding(6, 4, 4, 4);
            this.sevenSegmentArray1.ElementWidth = 10;
            this.sevenSegmentArray1.ItalicFactor = -0.1F;
            this.sevenSegmentArray1.Location = new System.Drawing.Point(186, 71);
            this.sevenSegmentArray1.Margin = new System.Windows.Forms.Padding(4);
            this.sevenSegmentArray1.Name = "sevenSegmentArray1";
            this.sevenSegmentArray1.Size = new System.Drawing.Size(533, 109);
            this.sevenSegmentArray1.TabIndex = 42;
            this.sevenSegmentArray1.TabStop = false;
            this.sevenSegmentArray1.Value = "";
            // 
            // connectionLBL
            // 
            this.connectionLBL.AutoSize = true;
            this.connectionLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionLBL.Location = new System.Drawing.Point(87, 609);
            this.connectionLBL.Name = "connectionLBL";
            this.connectionLBL.Size = new System.Drawing.Size(207, 29);
            this.connectionLBL.TabIndex = 39;
            this.connectionLBL.Text = "Connection Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(322, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 29);
            this.label2.TabIndex = 38;
            this.label2.Text = "Time (ms)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(117, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 29);
            this.label1.TabIndex = 36;
            this.label1.Text = "Period (ms)";
            // 
            // metroToggle1
            // 
            this.metroToggle1.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroToggle1.Location = new System.Drawing.Point(637, 246);
            this.metroToggle1.Name = "metroToggle1";
            this.metroToggle1.Size = new System.Drawing.Size(92, 34);
            this.metroToggle1.TabIndex = 51;
            this.metroToggle1.Text = "Off";
            this.metroToggle1.UseSelectable = true;
            this.metroToggle1.CheckedChanged += new System.EventHandler(this.MetroToggle1_CheckedChanged);
            // 
            // readBTN
            // 
            this.readBTN.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.readBTN.Location = new System.Drawing.Point(111, 471);
            this.readBTN.Name = "readBTN";
            this.readBTN.Size = new System.Drawing.Size(205, 73);
            this.readBTN.Style = MetroFramework.MetroColorStyle.Blue;
            this.readBTN.TabIndex = 52;
            this.readBTN.Text = "Read";
            this.readBTN.UseSelectable = true;
            this.readBTN.UseStyleColors = true;
            this.readBTN.Click += new System.EventHandler(this.readBTN_Click);
            // 
            // zeroBTN
            // 
            this.zeroBTN.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.zeroBTN.Location = new System.Drawing.Point(367, 471);
            this.zeroBTN.Name = "zeroBTN";
            this.zeroBTN.Size = new System.Drawing.Size(205, 73);
            this.zeroBTN.Style = MetroFramework.MetroColorStyle.Green;
            this.zeroBTN.TabIndex = 53;
            this.zeroBTN.Text = "Zero";
            this.zeroBTN.UseSelectable = true;
            this.zeroBTN.UseStyleColors = true;
            // 
            // stopBTN
            // 
            this.stopBTN.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.stopBTN.Location = new System.Drawing.Point(622, 471);
            this.stopBTN.Name = "stopBTN";
            this.stopBTN.Size = new System.Drawing.Size(205, 73);
            this.stopBTN.Style = MetroFramework.MetroColorStyle.Red;
            this.stopBTN.TabIndex = 54;
            this.stopBTN.Text = "Stop";
            this.stopBTN.UseSelectable = true;
            this.stopBTN.UseStyleColors = true;
            // 
            // unitCB
            // 
            this.unitCB.FormattingEnabled = true;
            this.unitCB.ItemHeight = 24;
            this.unitCB.Items.AddRange(new object[] {
            "Gram",
            "KG",
            "Ounces",
            "Pounds"});
            this.unitCB.Location = new System.Drawing.Point(117, 380);
            this.unitCB.Name = "unitCB";
            this.unitCB.Size = new System.Drawing.Size(207, 30);
            this.unitCB.TabIndex = 55;
            this.unitCB.UseSelectable = true;
            this.unitCB.SelectedIndexChanged += new System.EventHandler(this.UnitCB_SelectedIndexChanged);
            // 
            // periodTB
            // 
            // 
            // 
            // 
            this.periodTB.CustomButton.Image = null;
            this.periodTB.CustomButton.Location = new System.Drawing.Point(129, 1);
            this.periodTB.CustomButton.Name = "";
            this.periodTB.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.periodTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.periodTB.CustomButton.TabIndex = 1;
            this.periodTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.periodTB.CustomButton.UseSelectable = true;
            this.periodTB.CustomButton.Visible = false;
            this.periodTB.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.periodTB.Lines = new string[] {
        "500"};
            this.periodTB.Location = new System.Drawing.Point(117, 251);
            this.periodTB.MaxLength = 32767;
            this.periodTB.Multiline = true;
            this.periodTB.Name = "periodTB";
            this.periodTB.PasswordChar = '\0';
            this.periodTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.periodTB.SelectedText = "";
            this.periodTB.SelectionLength = 0;
            this.periodTB.SelectionStart = 0;
            this.periodTB.ShortcutsEnabled = true;
            this.periodTB.Size = new System.Drawing.Size(161, 33);
            this.periodTB.TabIndex = 56;
            this.periodTB.Text = "500";
            this.periodTB.UseSelectable = true;
            this.periodTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.periodTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // timeTB
            // 
            // 
            // 
            // 
            this.timeTB.CustomButton.Image = null;
            this.timeTB.CustomButton.Location = new System.Drawing.Point(129, 1);
            this.timeTB.CustomButton.Name = "";
            this.timeTB.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.timeTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.timeTB.CustomButton.TabIndex = 1;
            this.timeTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.timeTB.CustomButton.UseSelectable = true;
            this.timeTB.CustomButton.Visible = false;
            this.timeTB.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.timeTB.Lines = new string[] {
        "50000"};
            this.timeTB.Location = new System.Drawing.Point(321, 251);
            this.timeTB.MaxLength = 32767;
            this.timeTB.Multiline = true;
            this.timeTB.Name = "timeTB";
            this.timeTB.PasswordChar = '\0';
            this.timeTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.timeTB.SelectedText = "";
            this.timeTB.SelectionLength = 0;
            this.timeTB.SelectionStart = 0;
            this.timeTB.ShortcutsEnabled = true;
            this.timeTB.Size = new System.Drawing.Size(161, 33);
            this.timeTB.TabIndex = 57;
            this.timeTB.Text = "50000";
            this.timeTB.UseSelectable = true;
            this.timeTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.timeTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label6.Location = new System.Drawing.Point(510, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 29);
            this.label6.TabIndex = 58;
            this.label6.Text = "Infint time:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label7.Location = new System.Drawing.Point(439, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 29);
            this.label7.TabIndex = 59;
            this.label7.Text = "Channel 2: ";
            // 
            // channelToggle
            // 
            this.channelToggle.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.channelToggle.Location = new System.Drawing.Point(578, 368);
            this.channelToggle.Name = "channelToggle";
            this.channelToggle.Size = new System.Drawing.Size(92, 34);
            this.channelToggle.TabIndex = 60;
            this.channelToggle.Text = "Off";
            this.channelToggle.UseSelectable = true;
            this.channelToggle.CheckedChanged += new System.EventHandler(this.ChannelToggle_CheckedChanged);
            // 
            // weightLBL
            // 
            this.weightLBL.AutoSize = true;
            this.weightLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightLBL.ForeColor = System.Drawing.Color.Red;
            this.weightLBL.Location = new System.Drawing.Point(732, 116);
            this.weightLBL.Name = "weightLBL";
            this.weightLBL.Size = new System.Drawing.Size(72, 29);
            this.weightLBL.TabIndex = 61;
            this.weightLBL.Text = "Gram";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 658);
            this.Controls.Add(this.weightLBL);
            this.Controls.Add(this.channelToggle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.timeTB);
            this.Controls.Add(this.periodTB);
            this.Controls.Add(this.unitCB);
            this.Controls.Add(this.stopBTN);
            this.Controls.Add(this.zeroBTN);
            this.Controls.Add(this.readBTN);
            this.Controls.Add(this.metroToggle1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.COM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sevenSegmentArray1);
            this.Controls.Add(this.connectionLBL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "USB Scale Software";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.COM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown COM;
        private System.Windows.Forms.Label label3;
        private DmitryBrant.CustomControls.SevenSegmentArray sevenSegmentArray1;
        private System.Windows.Forms.Label connectionLBL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroToggle metroToggle1;
        private MetroFramework.Controls.MetroButton readBTN;
        private MetroFramework.Controls.MetroButton zeroBTN;
        private MetroFramework.Controls.MetroButton stopBTN;
        private MetroFramework.Controls.MetroComboBox unitCB;
        private MetroFramework.Controls.MetroTextBox periodTB;
        private MetroFramework.Controls.MetroTextBox timeTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroToggle channelToggle;
        private System.Windows.Forms.Label weightLBL;
    }
}