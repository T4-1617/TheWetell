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
        System.Collections.ArrayList _customers;
        int number;

        public Form1()
        {
            InitializeComponent();

            _customers = new System.Collections.ArrayList();

            // Static customers
            Customer c = new Customer() { Name = "Nikola Tesla" };
            c.CreateAccount(5000);
            _customers.Add(c);

            c = new Customer() { Name = "Alfred Nobel" };
            c.CreateAccount(10000);
            _customers.Add(c);

            // Combobox items
            cbxSelectUser.Items.Add(new ComboBoxItem() { Text = "<Select option>", Value = 0 });
            cbxSelectUser.Items.Add(new ComboBoxItem() { Text = "Customer", Value = 1 });
            cbxSelectUser.Items.Add(new ComboBoxItem() { Text = "Employee", Value = 2 });

            // Shows the first value in combobox
            cbxSelectUser.SelectedIndex = 0;

            // Hides all panels and buttons
            GUI();
        }

        // Adds all user to listbox
        void CheckUsers()
        {
            lbxUsers.Items.Clear();
            foreach (Customer user in _customers)
            {
                lbxUsers.Items.Add(user);
            }
        }

        // Adds all accounts to listbox
        void CheckAccounts()
        {
            lbxUserAccounts.Items.Clear();
            Customer customer = (Customer)lbxUsers.SelectedItem;
            foreach (Account account in customer.GetAllAccounts())
            {
                lbxUserAccounts.Items.Add(account);
            }
        }

        // Adds all transactions to listbox
        void CheckTransactions()
        {
            lbxTransactions.Items.Clear();
            Account account = (Account)lbxUserAccounts.SelectedItem;

            foreach (Transaction transaction in account.GetAllTransactions())
            {
                transaction.User = lbxUsers.SelectedItem.ToString();
                transaction.Account = lbxUserAccounts.SelectedItem.ToString();
                lbxTransactions.Items.Add(transaction);
            }
        }

        // Hides all the buttons and panels
        void GUI()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Panel || control is Button)
                {
                    control.Visible = false;
                }
            }
            tbxBalance.ReadOnly = true;
        }

        // GUI for customers only
        void CustomerGUI(bool visible)
        {
            pnlBalance.Visible = visible;
            pnlAddCash.Visible = visible;
            pnlWithdrawCash.Visible = visible;

            btnInvolement.Visible = false;
        }

        // GUI for employees only
        void EmployeeGUI(bool visible)
        {
            btnOpenAccount.Visible = visible;

            pnlBalance.Visible = false;
            pnlAddCash.Visible = false;
            pnlWithdrawCash.Visible = false;
        }

        // Method for checking balance of current choosen account
        void Balance()
        {
            Account account = (Account)lbxUserAccounts.SelectedItem;
            tbxBalance.Text = account.Balance.ToString();

            pnlBalance.Visible = true;
        }

        // Method to deposit cash into choosen account
        void AddCash()
        {
            Account account = (Account)lbxUserAccounts.SelectedItem;

            number = Convert.ToInt32(tbxAddCash.Text);
            number = int.Parse(tbxAddCash.Text);

            account.Deposit(number);
            Balance();
        }

        //Method to withdraw cash from choosen account
        void WithdrawCash()
        {
            Account account = (Account)lbxUserAccounts.SelectedItem;

            number = Convert.ToInt32(tbxWithdraw.Text);
            number = int.Parse(tbxWithdraw.Text);

            int temp = account.Balance - number;

            if (temp > 500)
            {
                account.Withdraw(number);
            }
            else
            {
                MessageBox.Show(string.Format("Can't withdraw {0} from account.", number), "Alert");
            }
            Balance();
        }

        // Opens a new account to selected user
        bool OpenAccount()
        {
            Customer customer = (Customer)lbxUsers.SelectedItem;

            number = Convert.ToInt32(tbxAddAccount.Text);
            number = int.Parse(tbxAddAccount.Text);

            return customer.CreateAccount(number);
        }

        private void cbxSelectUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            GUI();
            lbxUserAccounts.Items.Clear();

            switch (cbxSelectUser.Text)
            {
                case "Customer":
                    CheckUsers();
                    break;
                case "Employee":
                    CheckUsers();
                    EmployeeGUI(true);
                    break;
                default:
                    lbxUsers.Items.Clear();
                    break;
            }
        }

        private void btnOpenAccount_Click(object sender, EventArgs e)
        {
            GUI();
            pnlOpenNewAccount.Visible = true;
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            if (OpenAccount())
            {
                GUI();
            }
        }

        private void lbxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            GUI();
            btnOpenAccount.Visible = true;

            if (cbxSelectUser.Text == "Employee")
            {
                EmployeeGUI(true);
            }

            CheckAccounts();
        }

        private void lbxUserAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxUserAccounts.SelectedItem is Account)
            {
                if (cbxSelectUser.Text == "Customer")
                {
                    pnlCustomerButtons.Visible = true;
                }
                else
                {
                    btnInvolement.Visible = true;
                }
            }

        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            CustomerGUI(false);
            Balance();
        }

        private void btnAddCash_Click(object sender, EventArgs e)
        {
            CustomerGUI(false);
            pnlAddCash.Visible = true;
            Balance();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            AddCash();
            tbxAddCash.Clear();
        }

        private void btnWithdrawCash_Click(object sender, EventArgs e)
        {
            CustomerGUI(false);
            pnlWithdrawCash.Visible = true;
            Balance();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            WithdrawCash();
            tbxWithdraw.Clear();
        }

        private void btnInvolement_Click(object sender, EventArgs e)
        {
            CheckTransactions();
            pnlTransactions.Visible = true;
        }
    }
}
