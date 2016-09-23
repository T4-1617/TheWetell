using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBooking
{
    class Employee
    {

    }
    public class Customer
    {
        Random r = new Random();

        public string Name { get; set; }
        public int ID { get; set; }

        //private ArrayList Accounts { get; set; }
        //public Customer()
        //{
        //    Accounts = new ArrayList();
        //}

        //public void CreateAccount()
        //{
        //    Accounts.Add(new Account() { AccountName = "Account", Balance = r.Next(1000, 5000), ID = 11 });
        //}

        public override string ToString()
        {
            return Name;
        }
    }

    public class Account
    {
        public string AccountName { get; set; }
        public int Balance { get; set; }
        public int ID { get; set; }

        public Account()
        { 
            AccountName = string.Format("Account{0}", ID);
            Balance = 1000;
            ID = ID;
        }

        public override string ToString()
        {
            return string.Format("Account{0}", ID);
        }
    }
}
