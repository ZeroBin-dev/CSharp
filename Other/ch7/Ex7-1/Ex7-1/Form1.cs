using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex7_1
{
    public partial class Form1 : Form
    {
        DateTime startTime;

        public Form1()
        {
            InitializeComponent();
            startTime = DateTime.Now;
        }

        public DateTime GetStartTime()
        {
            return startTime;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("로드");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GetStartTime().ToString());
        }
    }
}
