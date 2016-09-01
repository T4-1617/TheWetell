using System;
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
    public partial class Calculator : Form
    {
        string ope = "";

        public Calculator()
        {
            InitializeComponent();
            textBox1.Focus();
            ButtonAdd.Text = "+";
            ButtonMinus.Text = "-";
            ButtonTimes.Text = "x";
            ButtonSplit.Text = "/";
            ButtonCalc.Text = "Calculate";
            listBox1.Text = "";
            //int test = GetNumber();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            ope = "+";
        }
        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            ope = "-";
        }
        private void ButtonTimes_Click(object sender, EventArgs e)
        {   
            ope = "x";
        }
        private void ButtonSplit_Click(object sender, EventArgs e)
        {   
            ope = "/";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ButtonCalc_Click(object sender, EventArgs e)
        {

            int number1 = int.Parse(textBox1.Text);
            int number2 = int.Parse(textBox2.Text);

            string error = "Mathematically impossible.";
            int answer;

            switch (ope)
            {
                case "+":
                    answer = number1 + number2;
                    listBox1.Items.Add(answer);
                    break;
                case "-":
                    answer = number1 - number2;
                    listBox1.Items.Add(answer);
                    break;

                case "x":
                    answer = number1 * number2;
                    listBox1.Items.Add(answer);
                    break;
                case "/":

                    if (number2 == 0)
                    {
                        listBox1.Items.Add(error);
                        MessageBox.Show("Can´t divide " + number1 + " with 0.", "Alert");
                        break;
                    } 

                    answer = number1 / number2;
                    listBox1.Items.Add(answer);
                    break;

                default:
                    break;
            }

            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox1.Focus();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }

}
