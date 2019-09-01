namespace HexabitzScale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.readBTN = new System.Windows.Forms.Button();
            this.zeroBTN = new System.Windows.Forms.Button();
            this.periodTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timeTB = new System.Windows.Forms.TextBox();
            this.connectionLBL = new System.Windows.Forms.Label();
            this.stopBTN = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.ifnCB = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.unitCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.weightLBL = new System.Windows.Forms.Label();
            this.COM = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sevenSegmentArray1 = new DmitryBrant.CustomControls.SevenSegmentArray();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.COM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // readBTN
            // 
            this.readBTN.BackColor = System.Drawing.Color.Lime;
            this.readBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readBTN.ForeColor = System.Drawing.Color.White;
            this.readBTN.Location = new System.Drawing.Point(121, 413);
            this.readBTN.Name = "readBTN";
            this.readBTN.Size = new System.Drawing.Size(184, 73);
            this.readBTN.TabIndex = 0;
            this.readBTN.Text = "Read";
            this.readBTN.UseVisualStyleBackColor = false;
            this.readBTN.Click += new System.EventHandler(this.readBTN_Click);
            // 
            // zeroBTN
            // 
            this.zeroBTN.BackColor = System.Drawing.Color.RoyalBlue;
            this.zeroBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroBTN.ForeColor = System.Drawing.Color.White;
            this.zeroBTN.Location = new System.Drawing.Point(318, 413);
            this.zeroBTN.Name = "zeroBTN";
            this.zeroBTN.Size = new System.Drawing.Size(184, 73);
            this.zeroBTN.TabIndex = 2;
            this.zeroBTN.Text = "Zero";
            this.zeroBTN.UseVisualStyleBackColor = false;
            this.zeroBTN.Click += new System.EventHandler(this.ZeroBTN_Click);
            // 
            // periodTB
            // 
            this.periodTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.periodTB.Location = new System.Drawing.Point(121, 236);
            this.periodTB.Name = "periodTB";
            this.periodTB.Size = new System.Drawing.Size(143, 34);
            this.periodTB.TabIndex = 4;
            this.periodTB.Text = "500";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Period";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(326, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Time";
            // 
            // timeTB
            // 
            this.timeTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeTB.Location = new System.Drawing.Point(331, 236);
            this.timeTB.Name = "timeTB";
            this.timeTB.Size = new System.Drawing.Size(143, 34);
            this.timeTB.TabIndex = 6;
            this.timeTB.Text = "50000";
            // 
            // connectionLBL
            // 
            this.connectionLBL.AutoSize = true;
            this.connectionLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionLBL.Location = new System.Drawing.Point(121, 515);
            this.connectionLBL.Name = "connectionLBL";
            this.connectionLBL.Size = new System.Drawing.Size(207, 29);
            this.connectionLBL.TabIndex = 11;
            this.connectionLBL.Text = "Connection Status";
            // 
            // stopBTN
            // 
            this.stopBTN.BackColor = System.Drawing.Color.Red;
            this.stopBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopBTN.ForeColor = System.Drawing.Color.White;
            this.stopBTN.Location = new System.Drawing.Point(508, 413);
            this.stopBTN.Name = "stopBTN";
            this.stopBTN.Size = new System.Drawing.Size(184, 73);
            this.stopBTN.TabIndex = 14;
            this.stopBTN.Text = "Stop";
            this.stopBTN.UseVisualStyleBackColor = false;
            this.stopBTN.Click += new System.EventHandler(this.StopBTN_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(22, 32);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(93, 21);
            this.radioButton1.TabIndex = 18;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Channel 1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(22, 59);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(93, 21);
            this.radioButton2.TabIndex = 19;
            this.radioButton2.Text = "Chennel 2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // ifnCB
            // 
            this.ifnCB.AutoSize = true;
            this.ifnCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ifnCB.Location = new System.Drawing.Point(492, 241);
            this.ifnCB.Name = "ifnCB";
            this.ifnCB.Size = new System.Drawing.Size(114, 29);
            this.ifnCB.TabIndex = 17;
            this.ifnCB.Text = "INF Time";
            this.ifnCB.UseVisualStyleBackColor = true;
            this.ifnCB.CheckedChanged += new System.EventHandler(this.IfnCB_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Location = new System.Drawing.Point(406, 297);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Channel";
            // 
            // unitCB
            // 
            this.unitCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.unitCB.FormattingEnabled = true;
            this.unitCB.Items.AddRange(new object[] {
            "Gram",
            "Kg",
            "Ounces",
            "Pounds"});
            this.unitCB.Location = new System.Drawing.Point(121, 329);
            this.unitCB.Name = "unitCB";
            this.unitCB.Size = new System.Drawing.Size(229, 37);
            this.unitCB.TabIndex = 24;
            this.unitCB.Text = "Gram";
            this.unitCB.SelectedIndexChanged += new System.EventHandler(this.UnitCB_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(121, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 29);
            this.label3.TabIndex = 26;
            this.label3.Text = "Weight Unit:";
            // 
            // weightLBL
            // 
            this.weightLBL.AutoSize = true;
            this.weightLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightLBL.ForeColor = System.Drawing.Color.Red;
            this.weightLBL.Location = new System.Drawing.Point(661, 74);
            this.weightLBL.Name = "weightLBL";
            this.weightLBL.Size = new System.Drawing.Size(129, 51);
            this.weightLBL.TabIndex = 27;
            this.weightLBL.Text = "Gram";
            // 
            // COM
            // 
            this.COM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.COM.Location = new System.Drawing.Point(508, 522);
            this.COM.Name = "COM";
            this.COM.Size = new System.Drawing.Size(60, 36);
            this.COM.TabIndex = 28;
            this.COM.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(433, 525);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 29);
            this.label4.TabIndex = 29;
            this.label4.Text = "COM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(659, 541);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Powerd by ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::USBScaleSoftware.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(743, 525);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
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
            this.sevenSegmentArray1.Location = new System.Drawing.Point(121, 40);
            this.sevenSegmentArray1.Margin = new System.Windows.Forms.Padding(4);
            this.sevenSegmentArray1.Name = "sevenSegmentArray1";
            this.sevenSegmentArray1.Size = new System.Drawing.Size(533, 109);
            this.sevenSegmentArray1.TabIndex = 21;
            this.sevenSegmentArray1.TabStop = false;
            this.sevenSegmentArray1.Value = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 585);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.COM);
            this.Controls.Add(this.weightLBL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.unitCB);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.sevenSegmentArray1);
            this.Controls.Add(this.ifnCB);
            this.Controls.Add(this.stopBTN);
            this.Controls.Add(this.connectionLBL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timeTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.periodTB);
            this.Controls.Add(this.zeroBTN);
            this.Controls.Add(this.readBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hexabitz Scale";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.COM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button readBTN;
        private System.Windows.Forms.Button zeroBTN;
        private System.Windows.Forms.TextBox periodTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox timeTB;
        private System.Windows.Forms.Label connectionLBL;
        private System.Windows.Forms.Button stopBTN;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private DmitryBrant.CustomControls.SevenSegmentArray sevenSegmentArray1;
        private System.Windows.Forms.CheckBox ifnCB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox unitCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label weightLBL;
        private System.Windows.Forms.NumericUpDown COM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

