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

            cbxSelectUser.Items.Add(new ComboBoxItem() { Text = "<Select option>", Value = 0 });
            cbxSelectUser.Items.Add(new ComboBoxItem() { Text = "Customer", Value = 1 });
            cbxSelectUser.Items.Add(new ComboBoxItem() { Text = "Employee", Value = 2 });

            cbxSelectUser.SelectedIndex = 0;

            GUI();
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

        void CheckUsers()
        {
            lbxUsers.Items.Clear();
            foreach (Customer user in _customers)
            {
                lbxUsers.Items.Add(user);
            }
        }

        void CheckAccounts()
        {
            lbxUserAccounts.Items.Clear();
            Customer customer = (Customer)lbxUsers.SelectedItem;
            foreach (Account account in customer.GetAllAccounts())
            {
                lbxUserAccounts.Items.Add(account);
            }
        }

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

        void CustomerGUI(bool visible)
        {
            pnlBalance.Visible = visible;
            pnlAddCash.Visible = visible;
            pnlWithdrawCash.Visible = visible;

            btnInvolement.Visible = false;
        }

        void EmployeeGUI(bool visible)
        {
            btnInvolement.Visible = visible;
            btnOpenAccount.Visible = visible;

            pnlBalance.Visible = false;
            pnlAddCash.Visible = false;
            pnlWithdrawCash.Visible = false;
        }

        void Balance()
        {
            Account account = (Account)lbxUserAccounts.SelectedItem;
            tbxBalance.Text = account.Balance.ToString();

            pnlBalance.Visible = true;
        }

        void AddCash()
        {
            Account account = (Account)lbxUserAccounts.SelectedItem;

            int number;
            number = Convert.ToInt32(tbxAddCash.Text);
            number = int.Parse(tbxAddCash.Text);

            account.Deposit(number);
            Transaction(true);
            Balance();
        }

        void WithdrawCash()
        {
            Account account = (Account)lbxUserAccounts.SelectedItem;

            int number;
            number = Convert.ToInt32(tbxWithdraw.Text);
            number = int.Parse(tbxWithdraw.Text);

            int temp = account.Balance - number;

            if (temp > 500)
            {
                account.Withdraw(number);
                Transaction(false);
            }
            else
            {
                MessageBox.Show(string.Format("Can't withdraw {0} from account.", number), "Alert");
            }
            Balance();
        }

        bool OpenAccount()
        {
            Customer customer = (Customer)lbxUsers.SelectedItem;

            int number;
            number = Convert.ToInt32(tbxAddAccount.Text);
            number = int.Parse(tbxAddAccount.Text);


            if (customer.CreateAccount(number))
            {
                customer.CreateAccount(number);
                return true;
            }
            else
            {
                return false;
            }
        }

        void Transaction(bool action)
        {
            Transaction transaction = new Transaction() { User = lbxUsers.SelectedItem.ToString(), Date = 270916, };
            if (action)
            {
                int number;
                number = Convert.ToInt32(tbxAddCash.Text);
                number = int.Parse(tbxAddCash.Text);

                transaction.Account = lbxUserAccounts.SelectedItem.ToString();
                transaction.Action = "Deposited";
                transaction.Amount = number;

                lbxTransactions.Items.Add(transaction);
            }
            else
            {
                int number;
                number = Convert.ToInt32(tbxWithdraw.Text);
                number = int.Parse(tbxWithdraw.Text);

                transaction.Account = lbxUserAccounts.SelectedItem.ToString();
                transaction.Action = "Withdrew";
                transaction.Amount = number;

                lbxTransactions.Items.Add(transaction);
            }
        }

        private void btnOpenAccount_Click(object sender, EventArgs e)
        {
            GUI();
            pnlOpenNewAccount.Visible = true;
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            Customer customer = (Customer)lbxUsers.SelectedItem;

            if (OpenAccount())
            {
                OpenAccount();
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
            else
            {

            }

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
            pnlTransactions.Visible = true;
        }
    }
}
