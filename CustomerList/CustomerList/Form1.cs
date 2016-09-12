using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerList
{
    public partial class Customers : Form
    {
        string status;
        int i = 100;

        public Customers()
        {
            InitializeComponent();
        }

        List<Customer> customers = new List<Customer>();

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();

            customer.ID = i;
            customer.FirstName = txtFirstName.Text;
            customer.LastName = txtLastName.Text;
            customer.Active = true;

            customers.Add(customer);

            if (customer.Active)
            {
                status = "Active";
            }
            else
            {
                status = "Unactive";
            }

            txtNumberCustomers.Text = string.Format("{0}", customers.Count);
            listBoxCustomers.Items.Add(i + ". " + customer.FullName() + " - " + "Status: " + status);

            i++;
            txtFirstName.Focus();
        }

        private void listBoxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer c = customers[listBoxCustomers.SelectedIndex];
            MessageBox.Show(string.Format("ID: {0}\nFist name: {1}\nLast name: {2}\nStatus: {3}", 
                c.ID, c.FirstName, c.LastName, c.Active), "Customer");
        }
    }
}
