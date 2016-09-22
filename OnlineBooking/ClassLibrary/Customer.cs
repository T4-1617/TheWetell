using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBooking
{

    class Employee
    {

    }

    class Customer
    {
        //System.Collections.ArrayList Accounts;

        public string CustomerName { get; set; }
    }

    class Account : Customer
    {
        public string AccountName { get; set; }
        public int AccountID { get; set; }
        public int Balance { get; set; }
    }
}
