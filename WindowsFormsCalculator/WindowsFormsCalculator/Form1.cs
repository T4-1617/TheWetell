﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "+";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = "-";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = "x";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = "/";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = "Calculate";
        }
    }
}