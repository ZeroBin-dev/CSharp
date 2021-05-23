using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex8_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = FlatStyle.Flat.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = FlatStyle.Popup.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = FlatStyle.Standard.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = FlatStyle.System.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void UpdateLabel(string s, bool b)
        {
            if (b)
            {
                label2.Text += s;
            }
            else
            {
                string str = label2.Text;
                int i = str.IndexOf(s);
                label2.Text = str.Remove(i, s.Length);
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabel(checkBox1.Text, checkBox1.Checked);
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabel(checkBox2.Text, checkBox2.Checked);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = radioButton1.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = radioButton2.Text;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Process.Start("Notepad.exe",label4.Text);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(linkLabel1.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Text = "ID : " + textBox1.Text + "\r\n" + "PW : " + textBox2.Text;
        }

        private void top_Click(object sender, EventArgs e)
        {
            int n = int.Parse(left.Text);
            right.Text = Convert.ToString(n,2);
        }

        private void bottom_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(right.Text, 2);
            left.Text = n.ToString();
        }
    }
}
