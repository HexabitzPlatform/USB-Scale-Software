namespace ArrayMessaging
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
            this.readBTN = new System.Windows.Forms.Button();
            this.displayLBL = new System.Windows.Forms.Label();
            this.zeroBTN = new System.Windows.Forms.Button();
            this.periodTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timeTB = new System.Windows.Forms.TextBox();
            this.connectionLBL = new System.Windows.Forms.Label();
            this.stopBTN = new System.Windows.Forms.Button();
            this.testBufferTB = new System.Windows.Forms.RichTextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.sevenSegmentArray1 = new DmitryBrant.CustomControls.SevenSegmentArray();
            this.ifnCB = new System.Windows.Forms.CheckBox();
            this.KGRB = new System.Windows.Forms.RadioButton();
            this.grameRB = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // readBTN
            // 
            this.readBTN.BackColor = System.Drawing.Color.Lime;
            this.readBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readBTN.ForeColor = System.Drawing.Color.White;
            this.readBTN.Location = new System.Drawing.Point(49, 413);
            this.readBTN.Name = "readBTN";
            this.readBTN.Size = new System.Drawing.Size(184, 73);
            this.readBTN.TabIndex = 0;
            this.readBTN.Text = "Read";
            this.readBTN.UseVisualStyleBackColor = false;
            this.readBTN.Click += new System.EventHandler(this.readBTN_Click);
            // 
            // displayLBL
            // 
            this.displayLBL.AutoSize = true;
            this.displayLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayLBL.ForeColor = System.Drawing.Color.Red;
            this.displayLBL.Location = new System.Drawing.Point(480, 507);
            this.displayLBL.Name = "displayLBL";
            this.displayLBL.Size = new System.Drawing.Size(302, 69);
            this.displayLBL.TabIndex = 1;
            this.displayLBL.Text = "77777777";
            this.displayLBL.Visible = false;
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
            this.periodTB.Location = new System.Drawing.Point(211, 234);
            this.periodTB.Name = "periodTB";
            this.periodTB.Size = new System.Drawing.Size(143, 34);
            this.periodTB.TabIndex = 4;
            this.periodTB.Text = "500";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Period";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(410, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Time";
            // 
            // timeTB
            // 
            this.timeTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeTB.Location = new System.Drawing.Point(415, 234);
            this.timeTB.Name = "timeTB";
            this.timeTB.Size = new System.Drawing.Size(143, 34);
            this.timeTB.TabIndex = 6;
            this.timeTB.Text = "5000";
            // 
            // connectionLBL
            // 
            this.connectionLBL.AutoSize = true;
            this.connectionLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionLBL.Location = new System.Drawing.Point(44, 515);
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
            this.stopBTN.Location = new System.Drawing.Point(576, 413);
            this.stopBTN.Name = "stopBTN";
            this.stopBTN.Size = new System.Drawing.Size(184, 73);
            this.stopBTN.TabIndex = 14;
            this.stopBTN.Text = "Stop";
            this.stopBTN.UseVisualStyleBackColor = false;
            this.stopBTN.Click += new System.EventHandler(this.StopBTN_Click);
            // 
            // testBufferTB
            // 
            this.testBufferTB.Location = new System.Drawing.Point(36, 257);
            this.testBufferTB.Name = "testBufferTB";
            this.testBufferTB.Size = new System.Drawing.Size(123, 103);
            this.testBufferTB.TabIndex = 15;
            this.testBufferTB.Text = "";
            this.testBufferTB.Visible = false;
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
            // sevenSegmentArray1
            // 
            this.sevenSegmentArray1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sevenSegmentArray1.ArrayCount = 6;
            this.sevenSegmentArray1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sevenSegmentArray1.ColorBackground = System.Drawing.SystemColors.Control;
            this.sevenSegmentArray1.ColorDark = System.Drawing.SystemColors.Control;
            this.sevenSegmentArray1.ColorLight = System.Drawing.Color.Red;
            this.sevenSegmentArray1.DecimalShow = true;
            this.sevenSegmentArray1.ElementPadding = new System.Windows.Forms.Padding(6, 4, 4, 4);
            this.sevenSegmentArray1.ElementWidth = 10;
            this.sevenSegmentArray1.ItalicFactor = -0.1F;
            this.sevenSegmentArray1.Location = new System.Drawing.Point(193, 44);
            this.sevenSegmentArray1.Margin = new System.Windows.Forms.Padding(4);
            this.sevenSegmentArray1.Name = "sevenSegmentArray1";
            this.sevenSegmentArray1.Size = new System.Drawing.Size(464, 109);
            this.sevenSegmentArray1.TabIndex = 21;
            this.sevenSegmentArray1.TabStop = false;
            this.sevenSegmentArray1.Value = "";
            // 
            // ifnCB
            // 
            this.ifnCB.AutoSize = true;
            this.ifnCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ifnCB.Location = new System.Drawing.Point(576, 239);
            this.ifnCB.Name = "ifnCB";
            this.ifnCB.Size = new System.Drawing.Size(114, 29);
            this.ifnCB.TabIndex = 17;
            this.ifnCB.Text = "INF Time";
            this.ifnCB.UseVisualStyleBackColor = true;
            this.ifnCB.CheckedChanged += new System.EventHandler(this.IfnCB_CheckedChanged);
            // 
            // KGRB
            // 
            this.KGRB.AutoSize = true;
            this.KGRB.Location = new System.Drawing.Point(29, 59);
            this.KGRB.Name = "KGRB";
            this.KGRB.Size = new System.Drawing.Size(46, 21);
            this.KGRB.TabIndex = 23;
            this.KGRB.Text = "Kg";
            this.KGRB.UseVisualStyleBackColor = true;
            // 
            // grameRB
            // 
            this.grameRB.AutoSize = true;
            this.grameRB.Checked = true;
            this.grameRB.Location = new System.Drawing.Point(29, 32);
            this.grameRB.Name = "grameRB";
            this.grameRB.Size = new System.Drawing.Size(64, 21);
            this.grameRB.TabIndex = 22;
            this.grameRB.TabStop = true;
            this.grameRB.Text = "Gram";
            this.grameRB.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grameRB);
            this.groupBox1.Controls.Add(this.KGRB);
            this.groupBox1.Location = new System.Drawing.Point(469, 288);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Weight unit";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Location = new System.Drawing.Point(205, 288);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Channel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 585);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sevenSegmentArray1);
            this.Controls.Add(this.ifnCB);
            this.Controls.Add(this.testBufferTB);
            this.Controls.Add(this.stopBTN);
            this.Controls.Add(this.connectionLBL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timeTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.periodTB);
            this.Controls.Add(this.zeroBTN);
            this.Controls.Add(this.displayLBL);
            this.Controls.Add(this.readBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Array Messaging";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button readBTN;
        private System.Windows.Forms.Label displayLBL;
        private System.Windows.Forms.Button zeroBTN;
        private System.Windows.Forms.TextBox periodTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox timeTB;
        private System.Windows.Forms.Label connectionLBL;
        private System.Windows.Forms.Button stopBTN;
        private System.Windows.Forms.RichTextBox testBufferTB;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private DmitryBrant.CustomControls.SevenSegmentArray sevenSegmentArray1;
        private System.Windows.Forms.CheckBox ifnCB;
        private System.Windows.Forms.RadioButton KGRB;
        private System.Windows.Forms.RadioButton grameRB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

