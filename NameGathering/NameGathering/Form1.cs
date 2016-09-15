using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameGathering
{
    public partial class Form1 : Form
    {
        System.Collections.ArrayList nameList;

        public Form1()
        {
            InitializeComponent();
            nameList = new System.Collections.ArrayList();
        }

        private void btnAddName_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            Employee employee = new Employee();

            if (rBtnCustomer.Checked)
            {
                nameList.Add(new Customer() { FirstName = txtFirstName.Text, LastName = txtLastName.Text });
                Display();
            }

            else if (rBtnEmployee.Checked)
            {
                nameList.Add(new Employee() { FirstName = txtFirstName.Text, LastName = txtLastName.Text });
                Display();
            }

            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtFirstName.Focus();
        }

        private void Display()
        {
            listBoxCustomers.Items.Clear();
            listBoxEmployees.Items.Clear();

            foreach (var name in nameList)
            {
                switch (name.GetType().Name)
                {
                    case "Customer":
                        listBoxCustomers.Items.Add(name);
                        listBoxCustomers.DisplayMember = "FullName";
                        break;

                    case "Employee":
                        listBoxEmployees.Items.Add(name);
                        listBoxEmployees.DisplayMember = "FullName";
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
