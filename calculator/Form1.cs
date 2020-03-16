using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "4";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox1.Text = "5";
        }

        private void button32_Click(object sender, EventArgs e)
        {
            textBox1.Text = "6";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "7";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text = "8";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox1.Text = "91";
        }
    }
}
