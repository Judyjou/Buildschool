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

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("7");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("8");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("9");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("4");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("5");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("6");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("1");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("2");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("3");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("0");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(".");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("(");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(")");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
