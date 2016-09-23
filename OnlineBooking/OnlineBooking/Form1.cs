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

        public Form1()
        {
            InitializeComponent();

            userList = new System.Collections.ArrayList();
            accountList = new System.Collections.ArrayList();

            userList.Add(new Customer() { Name = "Nikola Tesla", ID = 1 });
            accountList.Add(new Account() { ID = 1 });
            accountList.Add(new Account() { ID = 1 });
            accountList.Add(new Account() { ID = 1 });

            userList.Add(new Customer() { Name = "Albert Einstien", ID = 2 });
            accountList.Add(new Account() { ID = 2 });
            accountList.Add(new Account() { ID = 2 });
            accountList.Add(new Account() { ID = 2 });

            userList.Add(new Customer() { Name = "Thomas Edison", ID = 3 });
            accountList.Add(new Account() { ID = 3 });
            accountList.Add(new Account() { ID = 3 });

            userList.Add(new Customer() { Name = "James Watt", ID = 4 });
            accountList.Add(new Account() { ID = 4 });
            accountList.Add(new Account() { ID = 4 });
            accountList.Add(new Account() { ID = 4 });
            accountList.Add(new Account() { ID = 4 });

            userList.Add(new Customer() { Name = "Urban Suedi", ID = 5 });
            accountList.Add(new Account() { ID = 5 });


            cbxSelectUser.Items.Add(new ComboBoxItem() { Text = "<Select option>", Value = 0 });
            cbxSelectUser.Items.Add(new ComboBoxItem() { Text = "Customer", Value = 1 });
            cbxSelectUser.Items.Add(new ComboBoxItem() { Text = "Employee", Value = 2 });

            cbxSelectUser.SelectedIndex = 0;

            GUI();
            tbxBalance.ReadOnly = true;
        }

        private void cbxSelectUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxUserAccounts.Items.Clear();
            switch (cbxSelectUser.Text)
            {
                case "Customer":
                    CheckUsers();
                    break;
                case "Employee":
                    CheckUsers();
                    break;
                default:
                    break;
            }
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
            }
        }

        void Involvement()
        {

        }

        void AddAccounts(int userID)
        {
            Customer customer = (Customer)lbxUsers.SelectedItem;
            accountList.Add(new Account() { ID = customer.ID });
        }

        void CheckBalance()
        {
            Account account = (Account)lbxUserAccounts.SelectedItem;
            tbxBalance.Text = account.Balance.ToString();
            pnlBalance.Visible = true;
        }

        void AddCash()
        {

        }

        void WithdrawCash()
        {
            Account account = (Account)lbxUserAccounts.SelectedItem;

        }

        void GUI()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Panel)
                {
                    control.Visible = false;
                }
            }
        }

        void CustomerGUI(bool visible)
        {
            pnlBalance.Visible = visible;
            pnlAddCash.Visible = visible;
            pnlWithdrawCash.Visible = visible;
        }

        private void lbxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer customer = (Customer)lbxUsers.SelectedItem;
            CheckAccounts();
        }

        private void lbxUserAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSelectUser.Text == "Customer" && lbxUserAccounts.SelectedItem is Account)
            {
                pnlCustomerButtons.Visible = true;
            }
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            CustomerGUI(false);
            CheckBalance();
        }

        private void btnAddCash_Click(object sender, EventArgs e)
        {
            CustomerGUI(false);
            AddCash();
        }

        private void btnWithdrawCash_Click(object sender, EventArgs e)
        {
            CustomerGUI(false);
            WithdrawCash();
        }
    }
}
