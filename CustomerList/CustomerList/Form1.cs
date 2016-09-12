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
        // Initializing some variables
        string status;
        int i = 100;

        public Customers()
        {
            InitializeComponent();
        }

        // Creates list that only can contain Customer
        List<Customer> customers = new List<Customer>();

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            // If i overrides 200, no more customers can be added
            if (i <= 200)
            {
                Customer customer = new Customer();

                customer.ID = i;
                customer.FirstName = txtFirstName.Text;
                customer.LastName = txtLastName.Text;
                customer.Active = true;

                // Adds customer to list
                customers.Add(customer);

                // Sets status depending on if bool is true/false 
                if (customer.Active)
                {
                    status = "Active";
                }
                else
                {
                    status = "Unactive";
                }

                // Changes the label when a new customer is added
                label1.Text = string.Format("You have {0} number of customers.", customers.Count);

                // Adds customers full name to listbox
                listBoxCustomers.Items.Add(customer.FullName());

                // Adds 1 to i
                i++;
                txtFirstName.Focus();
            }
        }

        private void listBoxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Chooses specific item (from customers in listbox) and calls it c
            Customer c = customers[listBoxCustomers.SelectedIndex];
            MessageBox.Show(string.Format("ID: {0}\nFirst name: {1}\nLast name: {2}\nStatus: {3}", 
                c.ID, c.FirstName, c.LastName, status), "Customer");
        }
    }
}
