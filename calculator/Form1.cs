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

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = "1";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox1.Text = "2";
        }

        private void button34_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox1.Text = ".";
        }
    }
}
