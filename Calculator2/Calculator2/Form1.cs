using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static char op = ' ';
        private void appendText(string str)
        {
            textBox1.Text = textBox1.Text + str;
        }

        private void clearText()
        {
            textBox1.Text = "";
        }

        private void calculate()
        {
            try
            {
                string[] inputs = textBox1.Text.Split(op);
                double d1 = Double.Parse(inputs[0]);
                double d2 = Double.Parse(inputs[1]);
                double result = 0;
                switch (op)
                {
                    case '+': result = d1 + d2; break;
                    case '-': result = d1 - d2; break;
                    case '*': result = d1 * d2; break;
                    case '/': result = d1 / d2; break;
                }
                textBox1.Text = result.ToString();
            }
            catch (Exception ex)
            {
                appendText(":Error ");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            appendText("6");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            appendText("5");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            appendText("4");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            appendText("3");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            appendText("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            appendText("9");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            appendText("7");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            appendText("2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            appendText("1");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.ActiveControl = this;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                double input = Double.Parse(textBox1.Text);
                double result = Math.Sqrt(input);
                textBox1.Text = result.ToString();
            }
            catch (Exception ex)
            {
                appendText(":Error");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            calculate();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                double input = Double.Parse(textBox1.Text);
                double result = 1 / input;
                textBox1.Text = result.ToString();
            }
            catch (Exception ex)
            {
                appendText(":Error");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            appendText("-");
            op = '-';
        }

        private void button14_Click(object sender, EventArgs e)
        {
            appendText("+");
            op = '+';
        }

        private void button13_Click(object sender, EventArgs e)
        {
            appendText("/");
            op = '/';
        }

        private void button12_Click(object sender, EventArgs e)
        {
            appendText("*");
            op = '*';
        }

        private void button11_Click(object sender, EventArgs e)
        {
            appendText(".");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            appendText("0");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            clearText();
        }
    }
}
