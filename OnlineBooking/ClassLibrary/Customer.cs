﻿using System;
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

        public Customer()
        {
            accounts = new ArrayList();
        }

        public Account GetAccount(int accountIndex)
        {
            return (Account)accounts[accountIndex];
        }

        public ArrayList GetAllAccounts()
        {
            return accounts;
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

        private ArrayList transactions { get; set; }

        // Shows balance of an account
        public int Balance
        {
            get { return _balance; }
        }

        // Adds cash to an account
        public void Deposit(int amount)
        {
            _balance += amount;
            transactions.Add(new Transaction() { Amount = amount, Action = "Deposited" });
        }

        // Withdraws cash from an account
        public void Withdraw(int amount)
        {
            _balance -= amount;
            transactions.Add(new Transaction() { Amount = amount, Action = "Withdraw" });
        }

        public Account(int balance)
        {
            this._balance = balance;
            transactions = new ArrayList();
        }

        public ArrayList GetAllTransactions()
        {
            return transactions;
        }

        public override string ToString()
        {
            return string.Format("Account {0}", ID);
        }
    }

    public class Transaction
    {
        public DateTime Date { get ; set; }
        public int Amount { get; set; }
        public string Action { get; set; }
        public string Account { get; set; }
        public string User { get; set; }

        // Constructor
        public Transaction()
        {
            Date = DateTime.UtcNow;
        }

        public override string ToString()
        {
            //return string.Format("{0}: {1} {2} from {3}. {4}",User, Action, Amount, Account, Date.ToString("G"));
            return string.Format("{0}: {1} {2}", Date.ToString("G"), Action, Amount);
        }
    }
}
