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
            this.ResetCmdButton = new System.Windows.Forms.Button();
            this.SendCMDButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IntervalCheck = new System.Windows.Forms.CheckBox();
            this.IntervalTime = new System.Windows.Forms.TextBox();
            this.HEXDisplay = new System.Windows.Forms.CheckBox();
            this.HEXSend = new System.Windows.Forms.CheckBox();
            this.CMDParm1Box = new System.Windows.Forms.TextBox();
            this.CMDParm2Box = new System.Windows.Forms.TextBox();
            this.CmdWordBox = new System.Windows.Forms.TextBox();
            this.PackEndBox = new System.Windows.Forms.ComboBox();
            this.PackEnd = new System.Windows.Forms.Label();
            this.CMDParm2 = new System.Windows.Forms.Label();
            this.CMDWord = new System.Windows.Forms.Label();
            this.CMDParm1 = new System.Windows.Forms.Label();
            this.PackHeadBox = new System.Windows.Forms.ComboBox();
            this.packHead = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ComNumLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BaudRateInfo = new System.Windows.Forms.ComboBox();
            this.BaudRateLable = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.OpenCom = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.SendTextBox = new System.Windows.Forms.TextBox();
            this.ClearSendButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SendGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SendGroupBox
            // 
            this.SendGroupBox.Controls.Add(this.ResetCmdButton);
            this.SendGroupBox.Controls.Add(this.SendCMDButton);
            this.SendGroupBox.Controls.Add(this.label1);
            this.SendGroupBox.Controls.Add(this.IntervalCheck);
            this.SendGroupBox.Controls.Add(this.IntervalTime);
            this.SendGroupBox.Controls.Add(this.HEXDisplay);
            this.SendGroupBox.Controls.Add(this.HEXSend);
            this.SendGroupBox.Controls.Add(this.CMDParm1Box);
            this.SendGroupBox.Controls.Add(this.CMDParm2Box);
            this.SendGroupBox.Controls.Add(this.CmdWordBox);
            this.SendGroupBox.Controls.Add(this.PackEndBox);
            this.SendGroupBox.Controls.Add(this.PackEnd);
            this.SendGroupBox.Controls.Add(this.CMDParm2);
            this.SendGroupBox.Controls.Add(this.CMDWord);
            this.SendGroupBox.Controls.Add(this.CMDParm1);
            this.SendGroupBox.Controls.Add(this.PackHeadBox);
            this.SendGroupBox.Controls.Add(this.packHead);
            this.SendGroupBox.Location = new System.Drawing.Point(8, 14);
            this.SendGroupBox.Name = "SendGroupBox";
            this.SendGroupBox.Size = new System.Drawing.Size(223, 249);
            this.SendGroupBox.TabIndex = 0;
            this.SendGroupBox.TabStop = false;
            this.SendGroupBox.Text = "发送控制";
            this.SendGroupBox.Enter += new System.EventHandler(this.HVGroupBox_Enter);
            // 
            // ResetCmdButton
            // 
            this.ResetCmdButton.Location = new System.Drawing.Point(119, 203);
            this.ResetCmdButton.Name = "ResetCmdButton";
            this.ResetCmdButton.Size = new System.Drawing.Size(86, 27);
            this.ResetCmdButton.TabIndex = 19;
            this.ResetCmdButton.Text = "重置指令";
            this.ResetCmdButton.UseVisualStyleBackColor = true;
            this.ResetCmdButton.Click += new System.EventHandler(this.ResetCmdButton_Click);
            // 
            // SendCMDButton
            // 
            this.SendCMDButton.Location = new System.Drawing.Point(8, 202);
            this.SendCMDButton.Name = "SendCMDButton";
            this.SendCMDButton.Size = new System.Drawing.Size(86, 28);
            this.SendCMDButton.TabIndex = 18;
            this.SendCMDButton.Text = "发送指令";
            this.SendCMDButton.UseVisualStyleBackColor = true;
            this.SendCMDButton.Click += new System.EventHandler(this.SendCMDButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 17;
            this.label1.Text = "间隔时间";
            // 
            // IntervalCheck
            // 
            this.IntervalCheck.AutoSize = true;
            this.IntervalCheck.Location = new System.Drawing.Point(151, 157);
            this.IntervalCheck.Name = "IntervalCheck";
            this.IntervalCheck.Size = new System.Drawing.Size(72, 16);
            this.IntervalCheck.TabIndex = 16;
            this.IntervalCheck.Text = "启用间隔";
            this.IntervalCheck.UseVisualStyleBackColor = true;
            this.IntervalCheck.CheckedChanged += new System.EventHandler(this.IntervalCheck_CheckedChanged);
            // 
            // IntervalTime
            // 
            this.IntervalTime.Enabled = false;
            this.IntervalTime.Location = new System.Drawing.Point(65, 152);
            this.IntervalTime.Name = "IntervalTime";
            this.IntervalTime.Size = new System.Drawing.Size(68, 21);
            this.IntervalTime.TabIndex = 6;
            this.IntervalTime.TextChanged += new System.EventHandler(this.IntervalTime_TextChanged);
            this.IntervalTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntervalTime_KeyPress);
            // 
            // HEXDisplay
            // 
            this.HEXDisplay.AutoSize = true;
            this.HEXDisplay.Location = new System.Drawing.Point(151, 54);
            this.HEXDisplay.Name = "HEXDisplay";
            this.HEXDisplay.Size = new System.Drawing.Size(66, 16);
            this.HEXDisplay.TabIndex = 14;
            this.HEXDisplay.Text = "HEX显示";
            this.HEXDisplay.UseVisualStyleBackColor = true;
            this.HEXDisplay.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // HEXSend
            // 
            this.HEXSend.AutoSize = true;
            this.HEXSend.Location = new System.Drawing.Point(151, 31);
            this.HEXSend.Name = "HEXSend";
            this.HEXSend.Size = new System.Drawing.Size(66, 16);
            this.HEXSend.TabIndex = 13;
            this.HEXSend.Text = "HEX发送";
            this.HEXSend.UseVisualStyleBackColor = true;
            // 
            // CMDParm1Box
            // 
            this.CMDParm1Box.Location = new System.Drawing.Point(65, 76);
            this.CMDParm1Box.Name = "CMDParm1Box";
            this.CMDParm1Box.Size = new System.Drawing.Size(68, 21);
            this.CMDParm1Box.TabIndex = 3;
            this.CMDParm1Box.Leave += new System.EventHandler(this.CMDParm1Box_Leave);
            // 
            // CMDParm2Box
            // 
            this.CMDParm2Box.Location = new System.Drawing.Point(65, 100);
            this.CMDParm2Box.Name = "CMDParm2Box";
            this.CMDParm2Box.Size = new System.Drawing.Size(68, 21);
            this.CMDParm2Box.TabIndex = 4;
            this.CMDParm2Box.Leave += new System.EventHandler(this.CMDParm2Box_Leave);
            // 
            // CmdWordBox
            // 
            this.CmdWordBox.Location = new System.Drawing.Point(65, 53);
            this.CmdWordBox.Name = "CmdWordBox";
            this.CmdWordBox.Size = new System.Drawing.Size(68, 21);
            this.CmdWordBox.TabIndex = 2;
            this.CmdWordBox.Leave += new System.EventHandler(this.CmdWordBox_Leave);
            // 
            // PackEndBox
            // 
            this.PackEndBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PackEndBox.FormattingEnabled = true;
            this.PackEndBox.Items.AddRange(new object[] {
            "校验和",
            "EE"});
            this.PackEndBox.Location = new System.Drawing.Point(65, 126);
            this.PackEndBox.Name = "PackEndBox";
            this.PackEndBox.Size = new System.Drawing.Size(68, 20);
            this.PackEndBox.TabIndex = 5;
            this.PackEndBox.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
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
            // CMDParm2
            // 
            this.CMDParm2.AutoSize = true;
            this.CMDParm2.Location = new System.Drawing.Point(6, 103);
            this.CMDParm2.Name = "CMDParm2";
            this.CMDParm2.Size = new System.Drawing.Size(35, 12);
            this.CMDParm2.TabIndex = 6;
            this.CMDParm2.Text = "参数2";
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
            // PackHeadBox
            // 
            this.PackHeadBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PackHeadBox.FormattingEnabled = true;
            this.PackHeadBox.Items.AddRange(new object[] {
            "AA"});
            this.PackHeadBox.Location = new System.Drawing.Point(65, 27);
            this.PackHeadBox.Name = "PackHeadBox";
            this.PackHeadBox.Size = new System.Drawing.Size(68, 20);
            this.PackHeadBox.TabIndex = 1;
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
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(676, 336);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(112, 37);
            this.SendButton.TabIndex = 15;
            this.SendButton.Text = "发送";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // SendTextBox
            // 
            this.SendTextBox.Location = new System.Drawing.Point(8, 336);
            this.SendTextBox.Multiline = true;
            this.SendTextBox.Name = "SendTextBox";
            this.SendTextBox.Size = new System.Drawing.Size(654, 100);
            this.SendTextBox.TabIndex = 10;
            this.SendTextBox.TextChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
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
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClearSendButton);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.SendTextBox);
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
        private System.Windows.Forms.ComboBox PackHeadBox;
        private System.Windows.Forms.Label packHead;
        private System.Windows.Forms.Label CMDWord;
        private System.Windows.Forms.Label CMDParm1;
        private System.Windows.Forms.Label CMDParm2;
        private System.Windows.Forms.ComboBox PackEndBox;
        private System.Windows.Forms.Label PackEnd;
        private System.Windows.Forms.TextBox CMDParm1Box;
        private System.Windows.Forms.TextBox CMDParm2Box;
        private System.Windows.Forms.TextBox CmdWordBox;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.CheckBox HEXDisplay;
        private System.Windows.Forms.CheckBox HEXSend;
        private System.Windows.Forms.TextBox SendTextBox;
        private System.Windows.Forms.Button ClearSendButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox IntervalCheck;
        private System.Windows.Forms.TextBox IntervalTime;
        private System.Windows.Forms.Button ResetCmdButton;
        private System.Windows.Forms.Button SendCMDButton;
    }
}

