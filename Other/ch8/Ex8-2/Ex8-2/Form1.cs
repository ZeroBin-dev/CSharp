using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex8_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Text = "";
            }else
            {
                MessageBox.Show("내용을 먼저 입력하세요.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex > -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }else
            {
                MessageBox.Show("항목을 먼저 선택하세요.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem != null)
            {
                comboBox1.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }else
            {
                MessageBox.Show("항목을 먼저 선택하세요.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                listBox1.Items.Add(comboBox1.SelectedItem);
                comboBox1.Items.Remove(comboBox1.SelectedItem);
            }else
            {
                MessageBox.Show("항목을 먼저 선택하세요.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string msg = "";
            foreach(object obj in checkedListBox1.SelectedItems)
            {
                msg += obj.ToString()+" ";
            }
            MessageBox.Show("당신의 선택은 : " + msg);
        }
    }
}
