using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex7_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetButtonText();
        }

        private void SetButtonText()
        {
            button1.Text = "Location : " + Location + "\n" + "Width : " + Width + "\n" + " Height : " + Height;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            SetButtonText();
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            SetButtonText();
        }
    }
}
