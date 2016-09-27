using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormProgram
{
    public partial class Form1 : Form
    {
        List<string> list = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello " + textBox1.Text + " " + textBox2.Text + "!");

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string saveToFile;
            saveToFile = string.Format("{0} {1}", textBox1.Text, textBox2.Text);

            list.Add(saveToFile);
            listBox1.Items.Add(saveToFile);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            System.IO.File.WriteAllLines(@"C:\Users\TheWetell\Desktop\TestText.txt", list);
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
    }
}
