using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }

        public virtual string FullName
        {
            get { return string.Format("{0} {1}", FirstName, LastName); }
        }
    }

    public class Customer : Person
    {
        public int CustomerID { get; set; }
    }

    public class Emplyee : Person
    {
        public int EmployeeID { get; set; }
        public string Title { get; set; }
        public int Salary { get; set; }
    }

    public class Supplier : Person
    {
        public string Company { get; set; }
    }
}