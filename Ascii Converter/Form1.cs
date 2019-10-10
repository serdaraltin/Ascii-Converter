using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ascii_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tx_char.Text = Convert.ToChar(Convert.ToInt32(textBox1.Text)).ToString();
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tx_char.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
            tx_ascii.Text = Convert.ToInt32(Convert.ToChar(textBox2.Text)).ToString();
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tx_ascii.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }
    }
}
