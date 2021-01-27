using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (textBox3.Enabled)
            {
                textBox3.Enabled = false;
            }

        }
        int a=0, b=0;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                b = 0;
                textBox2.Text = "0";
            }
            b = int.Parse(textBox2.Text);


            if (a != 0)
            {
                textBox3.Text = (a + b).ToString();
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                a = 0;
                textBox1.Text = 0.ToString();
            }
            a = int.Parse( textBox1.Text);

            if (b != 0)
            {
                textBox3.Text = (a + b).ToString();
            }

        }
    }
}
