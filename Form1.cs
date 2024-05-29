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

        }
        /////////////////////////////数据接收///////////////////////////////////////
        private void Port_DataReceive(object sender, SerialDataReceivedEventArgs e)
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        }
    }
}
