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
            this.connectBTN = new System.Windows.Forms.Button();
            this.displayLBL = new System.Windows.Forms.Label();
            this.zeroBTN = new System.Windows.Forms.Button();
            this.calibrationBTN = new System.Windows.Forms.Button();
            this.periodTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timeTB = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.connectionLBL = new System.Windows.Forms.Label();
            this.startBTN = new System.Windows.Forms.Button();
            this.stopBTN = new System.Windows.Forms.Button();
            this.testBufferTB = new System.Windows.Forms.RichTextBox();
            this.openBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // connectBTN
            // 
            this.connectBTN.BackColor = System.Drawing.Color.Lime;
            this.connectBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectBTN.ForeColor = System.Drawing.Color.White;
            this.connectBTN.Location = new System.Drawing.Point(49, 288);
            this.connectBTN.Name = "connectBTN";
            this.connectBTN.Size = new System.Drawing.Size(184, 73);
            this.connectBTN.TabIndex = 0;
            this.connectBTN.Text = "Connect";
            this.connectBTN.UseVisualStyleBackColor = false;
            this.connectBTN.Click += new System.EventHandler(this.ConnectBTN_Click);
            // 
            // displayLBL
            // 
            this.displayLBL.AutoSize = true;
            this.displayLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayLBL.ForeColor = System.Drawing.Color.Red;
            this.displayLBL.Location = new System.Drawing.Point(279, 47);
            this.displayLBL.Name = "displayLBL";
            this.displayLBL.Size = new System.Drawing.Size(200, 69);
            this.displayLBL.TabIndex = 1;
            this.displayLBL.Text = "77777";
            // 
            // zeroBTN
            // 
            this.zeroBTN.BackColor = System.Drawing.Color.RoyalBlue;
            this.zeroBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroBTN.ForeColor = System.Drawing.Color.White;
            this.zeroBTN.Location = new System.Drawing.Point(49, 367);
            this.zeroBTN.Name = "zeroBTN";
            this.zeroBTN.Size = new System.Drawing.Size(184, 73);
            this.zeroBTN.TabIndex = 2;
            this.zeroBTN.Text = "Zero";
            this.zeroBTN.UseVisualStyleBackColor = false;
            this.zeroBTN.Click += new System.EventHandler(this.ZeroBTN_Click);
            // 
            // calibrationBTN
            // 
            this.calibrationBTN.BackColor = System.Drawing.Color.Gray;
            this.calibrationBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calibrationBTN.ForeColor = System.Drawing.Color.White;
            this.calibrationBTN.Location = new System.Drawing.Point(49, 446);
            this.calibrationBTN.Name = "calibrationBTN";
            this.calibrationBTN.Size = new System.Drawing.Size(184, 73);
            this.calibrationBTN.TabIndex = 3;
            this.calibrationBTN.Text = "Calibration";
            this.calibrationBTN.UseVisualStyleBackColor = false;
            this.calibrationBTN.Click += new System.EventHandler(this.CalibrationBTN_Click);
            // 
            // periodTB
            // 
            this.periodTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.periodTB.Location = new System.Drawing.Point(399, 256);
            this.periodTB.Name = "periodTB";
            this.periodTB.Size = new System.Drawing.Size(143, 34);
            this.periodTB.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(394, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Period";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(598, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Time";
            // 
            // timeTB
            // 
            this.timeTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeTB.Location = new System.Drawing.Point(603, 256);
            this.timeTB.Name = "timeTB";
            this.timeTB.Size = new System.Drawing.Size(143, 34);
            this.timeTB.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(395, 456);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 34);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(565, 456);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(143, 34);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(486, 525);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(143, 34);
            this.textBox3.TabIndex = 10;
            // 
            // connectionLBL
            // 
            this.connectionLBL.AutoSize = true;
            this.connectionLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionLBL.Location = new System.Drawing.Point(44, 619);
            this.connectionLBL.Name = "connectionLBL";
            this.connectionLBL.Size = new System.Drawing.Size(207, 29);
            this.connectionLBL.TabIndex = 11;
            this.connectionLBL.Text = "Connection Status";
            // 
            // startBTN
            // 
            this.startBTN.BackColor = System.Drawing.Color.Lime;
            this.startBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBTN.ForeColor = System.Drawing.Color.White;
            this.startBTN.Location = new System.Drawing.Point(49, 525);
            this.startBTN.Name = "startBTN";
            this.startBTN.Size = new System.Drawing.Size(89, 73);
            this.startBTN.TabIndex = 13;
            this.startBTN.Text = "Start";
            this.startBTN.UseVisualStyleBackColor = false;
            this.startBTN.Click += new System.EventHandler(this.StartBTN_Click);
            // 
            // stopBTN
            // 
            this.stopBTN.BackColor = System.Drawing.Color.Red;
            this.stopBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopBTN.ForeColor = System.Drawing.Color.White;
            this.stopBTN.Location = new System.Drawing.Point(144, 525);
            this.stopBTN.Name = "stopBTN";
            this.stopBTN.Size = new System.Drawing.Size(89, 73);
            this.stopBTN.TabIndex = 14;
            this.stopBTN.Text = "Stop";
            this.stopBTN.UseVisualStyleBackColor = false;
            this.stopBTN.Click += new System.EventHandler(this.StopBTN_Click);
            // 
            // testBufferTB
            // 
            this.testBufferTB.Location = new System.Drawing.Point(49, 33);
            this.testBufferTB.Name = "testBufferTB";
            this.testBufferTB.Size = new System.Drawing.Size(184, 249);
            this.testBufferTB.TabIndex = 15;
            this.testBufferTB.Text = "";
            // 
            // openBTN
            // 
            this.openBTN.BackColor = System.Drawing.Color.Lime;
            this.openBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openBTN.ForeColor = System.Drawing.Color.White;
            this.openBTN.Location = new System.Drawing.Point(258, 525);
            this.openBTN.Name = "openBTN";
            this.openBTN.Size = new System.Drawing.Size(89, 73);
            this.openBTN.TabIndex = 16;
            this.openBTN.Text = "Open";
            this.openBTN.UseVisualStyleBackColor = false;
            this.openBTN.Click += new System.EventHandler(this.OpenBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 680);
            this.Controls.Add(this.openBTN);
            this.Controls.Add(this.testBufferTB);
            this.Controls.Add(this.stopBTN);
            this.Controls.Add(this.startBTN);
            this.Controls.Add(this.connectionLBL);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timeTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.periodTB);
            this.Controls.Add(this.calibrationBTN);
            this.Controls.Add(this.zeroBTN);
            this.Controls.Add(this.displayLBL);
            this.Controls.Add(this.connectBTN);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Array Messaging";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectBTN;
        private System.Windows.Forms.Label displayLBL;
        private System.Windows.Forms.Button zeroBTN;
        private System.Windows.Forms.Button calibrationBTN;
        private System.Windows.Forms.TextBox periodTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox timeTB;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label connectionLBL;
        private System.Windows.Forms.Button startBTN;
        private System.Windows.Forms.Button stopBTN;
        private System.Windows.Forms.RichTextBox testBufferTB;
        private System.Windows.Forms.Button openBTN;
    }
}

