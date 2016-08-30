using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleNameProgram
{
    class Program
    {

        static void Main( string[] args)
        {

            string firstName = "";
            string lastName = "";

            Console.WriteLine("What´s your first name?");
            firstName = ReadName();

            Console.WriteLine("What´s your last name?");
            lastName = ReadName();

            Console.WriteLine("Hello "+ lastName + "!");

        }

        private static string ReadName()
        {
            string name;

            while (true)
            {
                name = Console.ReadLine();
                if (name != "")
                {
                    break;
                }
                Console.WriteLine("Please enter a name:");
            }

            return name;
        }
    }
}
