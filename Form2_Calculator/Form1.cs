﻿using System;
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

    }
}
