using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace OnlineBooking
{
    public partial class Form1 : Form
    {
        System.Collections.ArrayList userList;
        System.Collections.ArrayList accountList;
        int userID = 0;

        public Form1()
        {
            InitializeComponent();

            userList = new System.Collections.ArrayList();
            accountList = new System.Collections.ArrayList();

            userList.Add(new Customer() { Name = "Alex Bro", ID = 1 });
            accountList.Add(new Account() { ID = 1 });
            accountList.Add(new Account() { ID = 1 });
            accountList.Add(new Account() { ID = 1 });
            accountList.Add(new Account() { ID = 1 });
            accountList.Add(new Account() { ID = 1 });

            userList.Add(new Customer() { Name = "Urban Suedi", ID = 21 });


            cbxSelectUser.Items.Add(new ComboBoxItem() { Text = "<Select option>", Value = 0 });
            cbxSelectUser.Items.Add(new ComboBoxItem() { Text = "Customer", Value = 1 });
            cbxSelectUser.Items.Add(new ComboBoxItem() { Text = "Employee", Value = 2 });

            cbxSelectUser.SelectedIndex = 0;

            CheckUsers();
        }

        private void cbxSelectUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void CheckUsers()
        {
            lbxUsers.Items.Clear();
            foreach (Customer user in userList)
            {
                lbxUsers.Items.Add(user);
            }
        }

        void CheckAccounts()
        {
            Customer customer = (Customer)lbxUsers.SelectedItem;
            lbxUserAccounts.Items.Clear();
            foreach (Account account in accountList)
            {
                if (customer.ID == account.ID)
                {
                    lbxUserAccounts.Items.Add(account);
                }
                else
                {
                    break;
                }
            }
        }

        private void lbxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer customer = (Customer)lbxUsers.SelectedItem;
            CheckAccounts();
        }
    }
}
