using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form2_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double total1 = 0;
        string theOperator;


        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += button2.Text;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += button3.Text;
        }

        private void buttonClear_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void buttonDot_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += buttonDot.Text;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            total1 += double.Parse(textBox1.Text);
            theOperator = "+";
            textBox1.Clear();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            total1 += double.Parse(textBox1.Text);
            theOperator = "-";
            textBox1.Clear();
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            double num2;
            double answer;

            num2 = double.Parse(textBox1.Text);

            switch (theOperator)
            {
                case "+":
                    answer = total1 + num2;
                    textBox1.Text = answer.ToString();
                    total1 = 0;
                    break;
                case "-":
                    answer = total1 - num2;
                    textBox1.Text = answer.ToString();
                    total1 = 0;
                    break;
               default:
                    answer = 0;
                    break;
            }
        }
    }
}
