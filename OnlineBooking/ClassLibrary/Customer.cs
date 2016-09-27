using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineBooking
{
    public class Customer
    {
        Random r = new Random();

        public string Name { get; set; }
        public int ID { get; set; }

        private ArrayList accounts { get; set; }
        private ArrayList transactions { get; set; }

        public Customer()
        {
            accounts = new ArrayList();
            transactions = new ArrayList();
        }

        public Account GetAccount(int accountIndex)
        {
            return (Account)accounts[accountIndex];
        }

        public ArrayList GetAllAccounts()
        {
            return accounts;
        }

        public ArrayList GetAllTransactions()
        {
            return transactions;
        }

        public bool CreateAccount(int initialDeposit)
        {
            if (initialDeposit >= 1000)
            {
                accounts.Add(new Account(initialDeposit));
                return true;
            }
            else
            {
                MessageBox.Show("Deposit must be 1000kr or more.", "Alert");
                return false;
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }

    public class Account
    {
        public string AccountName { get { return string.Format("Account: {0}kr", Balance); } }
        private int _balance;
        public int ID { get; set; }

        public int Balance
        {
            get { return _balance; }
        }

        public void Deposit(int amount)
        {
            _balance += amount;
        }

        public void Withdraw(int amount)
        {
            _balance -= amount;
        }

        public Account(int balance)
        {
            this._balance = balance;
        }

        public override string ToString()
        {
            return string.Format("Account {0}", ID);
        }
    }

    public class Transaction
    {
        public int Date { get; set; }
        public int Amount { get; set; }
        public string Action { get; set; }
        public string Account { get; set; }
        public string User { get; set; }

        public Transaction()
        {

        }

        public override string ToString()
        {
            return string.Format("{0}: {1} {2} from {3}. {4}",User, Action, Amount, Account, Date);
        }
    }
}
