namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SendGroupBox = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ComNumLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BaudRateInfo = new System.Windows.Forms.ComboBox();
            this.BaudRateLable = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.OpenCom = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.packHead = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.CMDParm1 = new System.Windows.Forms.Label();
            this.CMDWord = new System.Windows.Forms.Label();
            this.CMDParm2 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.PackEnd = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.HEXSend = new System.Windows.Forms.CheckBox();
            this.HEXDisney = new System.Windows.Forms.CheckBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.ClearSendButton = new System.Windows.Forms.Button();
            this.SendGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SendGroupBox
            // 
            this.SendGroupBox.Controls.Add(this.HEXDisney);
            this.SendGroupBox.Controls.Add(this.HEXSend);
            this.SendGroupBox.Controls.Add(this.textBox4);
            this.SendGroupBox.Controls.Add(this.textBox3);
            this.SendGroupBox.Controls.Add(this.textBox2);
            this.SendGroupBox.Controls.Add(this.comboBox6);
            this.SendGroupBox.Controls.Add(this.PackEnd);
            this.SendGroupBox.Controls.Add(this.CMDParm2);
            this.SendGroupBox.Controls.Add(this.CMDWord);
            this.SendGroupBox.Controls.Add(this.CMDParm1);
            this.SendGroupBox.Controls.Add(this.comboBox2);
            this.SendGroupBox.Controls.Add(this.packHead);
            this.SendGroupBox.Location = new System.Drawing.Point(8, 14);
            this.SendGroupBox.Name = "SendGroupBox";
            this.SendGroupBox.Size = new System.Drawing.Size(223, 249);
            this.SendGroupBox.TabIndex = 0;
            this.SendGroupBox.TabStop = false;
            this.SendGroupBox.Text = "发送控制";
            this.SendGroupBox.Enter += new System.EventHandler(this.HVGroupBox_Enter);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(237, 14);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(335, 249);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ComNumLabel
            // 
            this.ComNumLabel.AutoSize = true;
            this.ComNumLabel.Location = new System.Drawing.Point(6, 27);
            this.ComNumLabel.Name = "ComNumLabel";
            this.ComNumLabel.Size = new System.Drawing.Size(41, 12);
            this.ComNumLabel.TabIndex = 3;
            this.ComNumLabel.Text = "串口号";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(68, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(110, 20);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // BaudRateInfo
            // 
            this.BaudRateInfo.FormattingEnabled = true;
            this.BaudRateInfo.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "115200"});
            this.BaudRateInfo.Location = new System.Drawing.Point(68, 50);
            this.BaudRateInfo.Name = "BaudRateInfo";
            this.BaudRateInfo.Size = new System.Drawing.Size(110, 20);
            this.BaudRateInfo.TabIndex = 6;
            this.BaudRateInfo.Text = "19200";
            this.BaudRateInfo.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // BaudRateLable
            // 
            this.BaudRateLable.AutoSize = true;
            this.BaudRateLable.Location = new System.Drawing.Point(6, 53);
            this.BaudRateLable.Name = "BaudRateLable";
            this.BaudRateLable.Size = new System.Drawing.Size(41, 12);
            this.BaudRateLable.TabIndex = 5;
            this.BaudRateLable.Text = "波特率";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(8, 176);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(188, 27);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Text = "清除接收";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // OpenCom
            // 
            this.OpenCom.Location = new System.Drawing.Point(8, 143);
            this.OpenCom.Name = "OpenCom";
            this.OpenCom.Size = new System.Drawing.Size(188, 27);
            this.OpenCom.TabIndex = 8;
            this.OpenCom.Text = "打开串口";
            this.OpenCom.UseVisualStyleBackColor = true;
            this.OpenCom.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OpenCom);
            this.groupBox1.Controls.Add(this.ComNumLabel);
            this.groupBox1.Controls.Add(this.ClearButton);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.BaudRateInfo);
            this.groupBox1.Controls.Add(this.BaudRateLable);
            this.groupBox1.Location = new System.Drawing.Point(578, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 209);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口参数控制";
            // 
            // packHead
            // 
            this.packHead.AutoSize = true;
            this.packHead.Location = new System.Drawing.Point(6, 30);
            this.packHead.Name = "packHead";
            this.packHead.Size = new System.Drawing.Size(29, 12);
            this.packHead.TabIndex = 0;
            this.packHead.Text = "包头";
            this.packHead.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(53, 27);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(44, 20);
            this.comboBox2.TabIndex = 1;
            // 
            // CMDParm1
            // 
            this.CMDParm1.AutoSize = true;
            this.CMDParm1.Location = new System.Drawing.Point(6, 79);
            this.CMDParm1.Name = "CMDParm1";
            this.CMDParm1.Size = new System.Drawing.Size(35, 12);
            this.CMDParm1.TabIndex = 2;
            this.CMDParm1.Text = "参数1";
            this.CMDParm1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // CMDWord
            // 
            this.CMDWord.AutoSize = true;
            this.CMDWord.Location = new System.Drawing.Point(4, 56);
            this.CMDWord.Name = "CMDWord";
            this.CMDWord.Size = new System.Drawing.Size(41, 12);
            this.CMDWord.TabIndex = 4;
            this.CMDWord.Text = "命令字";
            // 
            // CMDParm2
            // 
            this.CMDParm2.AutoSize = true;
            this.CMDParm2.Location = new System.Drawing.Point(6, 103);
            this.CMDParm2.Name = "CMDParm2";
            this.CMDParm2.Size = new System.Drawing.Size(35, 12);
            this.CMDParm2.TabIndex = 6;
            this.CMDParm2.Text = "参数2";
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(53, 126);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(44, 20);
            this.comboBox6.TabIndex = 9;
            // 
            // PackEnd
            // 
            this.PackEnd.AutoSize = true;
            this.PackEnd.Location = new System.Drawing.Point(6, 129);
            this.PackEnd.Name = "PackEnd";
            this.PackEnd.Size = new System.Drawing.Size(29, 12);
            this.PackEnd.TabIndex = 8;
            this.PackEnd.Text = "包尾";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(53, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(44, 21);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(53, 100);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(44, 21);
            this.textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(53, 76);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(44, 21);
            this.textBox4.TabIndex = 12;
            // 
            // HEXSend
            // 
            this.HEXSend.AutoSize = true;
            this.HEXSend.Location = new System.Drawing.Point(139, 31);
            this.HEXSend.Name = "HEXSend";
            this.HEXSend.Size = new System.Drawing.Size(66, 16);
            this.HEXSend.TabIndex = 13;
            this.HEXSend.Text = "HEX发送";
            this.HEXSend.UseVisualStyleBackColor = true;
            // 
            // HEXDisney
            // 
            this.HEXDisney.AutoSize = true;
            this.HEXDisney.Location = new System.Drawing.Point(139, 52);
            this.HEXDisney.Name = "HEXDisney";
            this.HEXDisney.Size = new System.Drawing.Size(66, 16);
            this.HEXDisney.TabIndex = 14;
            this.HEXDisney.Text = "HEX显示";
            this.HEXDisney.UseVisualStyleBackColor = true;
            this.HEXDisney.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(676, 336);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(112, 37);
            this.SendButton.TabIndex = 15;
            this.SendButton.Text = "发送";
            this.SendButton.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(8, 336);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(654, 100);
            this.textBox5.TabIndex = 10;
            // 
            // ClearSendButton
            // 
            this.ClearSendButton.Location = new System.Drawing.Point(676, 403);
            this.ClearSendButton.Name = "ClearSendButton";
            this.ClearSendButton.Size = new System.Drawing.Size(112, 33);
            this.ClearSendButton.TabIndex = 16;
            this.ClearSendButton.Text = "清除发送";
            this.ClearSendButton.UseVisualStyleBackColor = true;
            this.ClearSendButton.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClearSendButton);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SendGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SendGroupBox.ResumeLayout(false);
            this.SendGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox SendGroupBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label ComNumLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox BaudRateInfo;
        private System.Windows.Forms.Label BaudRateLable;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button OpenCom;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label packHead;
        private System.Windows.Forms.Label CMDWord;
        private System.Windows.Forms.Label CMDParm1;
        private System.Windows.Forms.Label CMDParm2;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label PackEnd;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.CheckBox HEXDisney;
        private System.Windows.Forms.CheckBox HEXSend;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button ClearSendButton;
    }
}

