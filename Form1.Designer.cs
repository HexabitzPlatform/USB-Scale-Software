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
            this.readGramBTN = new System.Windows.Forms.Button();
            this.displayLBL = new System.Windows.Forms.Label();
            this.zeroBTN = new System.Windows.Forms.Button();
            this.periodTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timeTB = new System.Windows.Forms.TextBox();
            this.connectionLBL = new System.Windows.Forms.Label();
            this.stopBTN = new System.Windows.Forms.Button();
            this.testBufferTB = new System.Windows.Forms.RichTextBox();
            this.ifnCB = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.readKGBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // readGramBTN
            // 
            this.readGramBTN.BackColor = System.Drawing.Color.Lime;
            this.readGramBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readGramBTN.ForeColor = System.Drawing.Color.White;
            this.readGramBTN.Location = new System.Drawing.Point(49, 413);
            this.readGramBTN.Name = "readGramBTN";
            this.readGramBTN.Size = new System.Drawing.Size(184, 73);
            this.readGramBTN.TabIndex = 0;
            this.readGramBTN.Text = "Read Gram";
            this.readGramBTN.UseVisualStyleBackColor = false;
            this.readGramBTN.Click += new System.EventHandler(this.readGramBTN_Click);
            // 
            // displayLBL
            // 
            this.displayLBL.AutoSize = true;
            this.displayLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayLBL.ForeColor = System.Drawing.Color.Red;
            this.displayLBL.Location = new System.Drawing.Point(279, 47);
            this.displayLBL.Name = "displayLBL";
            this.displayLBL.Size = new System.Drawing.Size(302, 69);
            this.displayLBL.TabIndex = 1;
            this.displayLBL.Text = "77777777";
            // 
            // zeroBTN
            // 
            this.zeroBTN.BackColor = System.Drawing.Color.RoyalBlue;
            this.zeroBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroBTN.ForeColor = System.Drawing.Color.White;
            this.zeroBTN.Location = new System.Drawing.Point(441, 413);
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
            this.periodTB.Location = new System.Drawing.Point(328, 234);
            this.periodTB.Name = "periodTB";
            this.periodTB.Size = new System.Drawing.Size(143, 34);
            this.periodTB.TabIndex = 4;
            this.periodTB.Text = "500";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Period";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(527, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Time";
            // 
            // timeTB
            // 
            this.timeTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeTB.Location = new System.Drawing.Point(532, 234);
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
            this.stopBTN.Location = new System.Drawing.Point(631, 413);
            this.stopBTN.Name = "stopBTN";
            this.stopBTN.Size = new System.Drawing.Size(184, 73);
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
            // ifnCB
            // 
            this.ifnCB.AutoSize = true;
            this.ifnCB.Location = new System.Drawing.Point(696, 246);
            this.ifnCB.Name = "ifnCB";
            this.ifnCB.Size = new System.Drawing.Size(86, 21);
            this.ifnCB.TabIndex = 17;
            this.ifnCB.Text = "INF Time";
            this.ifnCB.UseVisualStyleBackColor = true;
            this.ifnCB.CheckedChanged += new System.EventHandler(this.IfnCB_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(328, 307);
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
            this.radioButton2.Location = new System.Drawing.Point(328, 334);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(93, 21);
            this.radioButton2.TabIndex = 19;
            this.radioButton2.Text = "Chennel 2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // readKGBTN
            // 
            this.readKGBTN.BackColor = System.Drawing.Color.Lime;
            this.readKGBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readKGBTN.ForeColor = System.Drawing.Color.White;
            this.readKGBTN.Location = new System.Drawing.Point(250, 413);
            this.readKGBTN.Name = "readKGBTN";
            this.readKGBTN.Size = new System.Drawing.Size(184, 73);
            this.readKGBTN.TabIndex = 20;
            this.readKGBTN.Text = "Read KG";
            this.readKGBTN.UseVisualStyleBackColor = false;
            this.readKGBTN.Click += new System.EventHandler(this.ReadKGBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 585);
            this.Controls.Add(this.readKGBTN);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
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
            this.Controls.Add(this.readGramBTN);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Array Messaging";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button readGramBTN;
        private System.Windows.Forms.Label displayLBL;
        private System.Windows.Forms.Button zeroBTN;
        private System.Windows.Forms.TextBox periodTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox timeTB;
        private System.Windows.Forms.Label connectionLBL;
        private System.Windows.Forms.Button stopBTN;
        private System.Windows.Forms.RichTextBox testBufferTB;
        private System.Windows.Forms.CheckBox ifnCB;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button readKGBTN;
    }
}

