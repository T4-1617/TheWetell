using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleNameProgram_310916
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;

            Console.WriteLine("Enter your firstname and lastname");
            name = "Kalle Anka";

            Console.WriteLine(name.Length);

            Console.WriteLine(name.Replace(" ", string.Empty).Length);

            string firstName;
            firstName = name.Split(' ').First();
            Console.WriteLine(firstName);

            string lastName;
            lastName = name.Split(' ').Last();
            Console.WriteLine(lastName);

            string reverseNames = name;
            reverseNames = string.Format("{0}, {1}", lastName, firstName);
            Console.WriteLine(reverseNames);

            string padFirstName = firstName.ToUpper();
            foreach (char item in padFirstName)
            {
                Console.WriteLine("----->" + item);
            }

            string padLastName = lastName.ToUpper();
            foreach (char item in padLastName)
            {
                Console.WriteLine("------>" + item);
            }



        }
    }
}
