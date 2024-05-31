using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Drawing.Text;
using System.ComponentModel.Design;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(Port_DataReceive);
            serialPort1.Encoding = Encoding.GetEncoding("UTF-8");
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Elapsed += new System.Timers.ElapsedEventHandler(OnTimerTrig);
            timer.AutoReset = false;
            timer.Enabled = false;

        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            throw new NotImplementedException();
        }
        private void OnTimerTrig(object sender,System.Timers.ElapsedEventArgs e)
        {

        }

        /////////////////////////////数据接收///////////////////////////////////////
        private void Port_DataReceive(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] buffer = new Byte[serialPort1.BytesToRead];
            if (!HEXDisplay.Checked)
            {
                try
                {   
                    string receive_data;
                    receive_data = serialPort1.ReadExisting();                
                    textBox1.AppendText(receive_data);
                    textBox1.AppendText("\r\n");
                }
                catch { }
            }
            else
            {
                serialPort1.Read(buffer,0, serialPort1.BytesToRead);
                textBox1.AppendText(BitConverter.ToString(buffer, 0, buffer.Length).Replace("-", " "));
                textBox1.AppendText("\r\n");
            }


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.BaudRate = Convert.ToInt32(BaudRateInfo.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (OpenCom.Text == "打开串口")
            {
                try
                {
                    serialPort1.PortName = comboBox1.Text;
                    serialPort1.BaudRate = Convert.ToInt32(BaudRateInfo.Text);
                    serialPort1.Open();
                    OpenCom.Text = "关闭串口";

                }
                catch
                {
                    MessageBox.Show("串口打开错误");
                }
            }
            else
            {
                try
                {
                    serialPort1.Close();
                    OpenCom.Text = "打开串口";
                }
                catch {}
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ScanCom_Click(object sender, EventArgs e)
        {
            ScanComAddToBox(serialPort1, comboBox1);
        }
        /// <summary>
        /// ////////////搜索串口////////////////////////
        /// </summary>
        /// <param name="Port"></param>
        /// <param name="comboBox"></param>
        private void ScanComAddToBox(SerialPort Port, ComboBox comboBox)
        {
            comboBox.Items.Clear();
            string[] Serial_Name = SerialPort.GetPortNames(); 
            if(Serial_Name.Length > 0)
            {
                Array.Sort(Serial_Name);
                Array.Reverse(Serial_Name);
                comboBox1.Items.AddRange(Serial_Name);
            }
            if (comboBox1.Items.Count != 0)
            {
                comboBox1.SelectedIndex = 0;
            }

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void HVGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            ScanComAddToBox(serialPort1, comboBox1);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SendTextBox.Clear();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void IntervalCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (IntervalCheck.Checked)
            {
                IntervalTime.Enabled = true;
            }
            else
            {
                IntervalTime.Enabled = false; ;
            }
        }

        private void IntervalTime_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void IntervalTime_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    if (HEXSend.Checked)
                    {
                        Byte[] strbyte = HextoByte(SendTextBox.Text);
                        serialPort1.Write(strbyte, 0, strbyte.Length);
                    }
                    else
                    {
                        serialPort1.Write(SendTextBox.Text);
                    }

                }
                catch
                {
                }
            }
            else
            {

                MessageBox.Show("请打开串口");
            }
        }
        /////////////16进制转byte/////////////////
        private byte[] HextoByte(string hex)
        {
            string a = hex.Replace(" ", "");
            int bytelength = 0;
            if (a.Length % 2 == 0)
            {
                bytelength = a.Length / 2;
            }
            else
            {
                bytelength = a.Length/2 +1; 
            }
            byte[] b = new byte[bytelength];
            for (int i = 0; i < bytelength; i++)
            {
                if (i == bytelength - 1)
                {
                    b[i] = Convert.ToByte(a.Substring(i * 2), 16);
                }
                else
                {
                    b[i] = Convert.ToByte(a.Substring(i*2,2), 16);
                }
            }
            return b;

        }
        /// <summary>
        /// byte转HEX
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        private string BytetoHex( byte[] bytes)
        {
            string str= null;
            if (bytes != null)
            {
                for (int i = 0; i < bytes.Length; i++)
                {
                    str += bytes[i].ToString("X2");
                }
            }
            return str;
        }

        private void SendCMDButton_Click(object sender, EventArgs e)
        {
            string cmd = null;
            int i = 1;
            int checksum = 0;
            string cmd_check_sum;
            if (PackHeadBox.Text != "")
            {
                if (CmdWordBox.Text != "")
                {
                    i++;
                    if (CMDParm1Box.Text != "")
                    {
                        i++;
                        if (CMDParm2Box.Text != "")
                        {
                            i++;
                        }
                    }
                }
            }
            string cmdLength = "0" + Convert.ToString(i);
            foreach (Control control in SendGroupBox.Controls)
            {
                if (control is TextBox)
                {
                    if (control.Name != "IntervalTime")
                    {
                        if (control.Text != "")
                        {
                            checksum += Convert.ToInt32(control.Text, 16);
                        }

                    }
                }
            }
            if (PackHeadBox.Text == "AA")
            {
                checksum += Convert.ToInt32(0xAA);
            }
            checksum += i;
            if (checksum > 0xFF)
            {
                checksum = checksum / 2;
            }
            cmd_check_sum = Convert.ToString(checksum, 16);
            if (PackHeadBox.Text != "")
            {
                cmd += PackHeadBox.Text;
            }
            if (cmdLength != "")
            {
                cmd += cmdLength;
            }
            if (CmdWordBox.Text != "")
            {
                cmd += CmdWordBox.Text;
            }
            if (CMDParm1Box.Text != "")
            {
                cmd += CMDParm1Box.Text;
            }
            if (CMDParm2Box.Text != "")
            {
                cmd += CMDParm2Box.Text;
            }
            if (PackEndBox.Text == "校验和")
            {
                cmd += cmd_check_sum;
            }
            else if (PackEndBox.Text == "EE")
            {
                cmd += PackEndBox.Text;
            }
            //          textBox1.Text = cmd;
            Byte[] strbyte = HextoByte(cmd);
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(strbyte, 0, strbyte.Length);
            }
            else
            {
                MessageBox.Show("请打开串口");
            }
        }

        private void ResetCmdButton_Click(object sender, EventArgs e)
        {
            PackHeadBox.ResetText();
            CmdWordBox.Clear();
            CMDParm1Box.Clear();
            CMDParm2Box.Clear();
            PackEndBox.ResetText();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void IntervalTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void CmdWordBox_Leave(object sender, EventArgs e)
        {
            int c;
            if (CmdWordBox.Text != "")
            {
                try
                {
                    c = Convert.ToInt32(CmdWordBox.Text, 16);
                }
                catch 
                {
                    MessageBox.Show("输入参数错误");
                    CmdWordBox.Clear();
                    c = 100;
                }
                if(c<10)
                {
                    CmdWordBox.Text = ("0" + Convert.ToString(c));

                }
            }
        }

        private void CMDParm1Box_Leave(object sender, EventArgs e)
        {
            int c;
            if (CMDParm1Box.Text != "")
            {
                try
                {
                    c = Convert.ToInt32(CMDParm1Box.Text, 16);
                }
                catch
                {
                    MessageBox.Show("输入参数错误");
                    CMDParm1Box.Clear();
                    c = 100;
                }
                if (c < 10)
                {
                    CMDParm1Box.Text = ("0" + Convert.ToString(c));

                }
            }
        }

        private void CMDParm2Box_Leave(object sender, EventArgs e)
        {
            int c;
            if (CMDParm2Box.Text != "")
            {
                try
                {
                    c = Convert.ToInt32(CMDParm2Box.Text, 16);
                }
                catch
                {
                    MessageBox.Show("输入参数错误");
                    CMDParm2Box.Clear();
                    c = 100;
                }
                if (c < 10)
                {
                    CMDParm2Box.Text = ("0" + Convert.ToString(c));

                }
            }
        }
    }
}
