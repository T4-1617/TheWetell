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

            string lowercaseNames = name.ToLower();
            Console.WriteLine(ReverseNames(lowercaseNames));

            Console.WriteLine(UpperLowerCase(name));

            Console.WriteLine(LeetSpeech(name));

        }

        private static string ReverseNames (string str)
        {
            char[] reverseNames = str.ToCharArray();
            Array.Reverse(reverseNames);
            return new string(reverseNames);
        }

        private static string UpperLowerCase (string str)
        {
            char[] upperLowerCase = str.ToCharArray();
            for (int i = 0; i < upperLowerCase.Count(); i++)
            {
                if (i % 2 == 0)
                {
                    upperLowerCase[i] = char.ToUpper(upperLowerCase[i]);
                }
            }

            return new string(upperLowerCase);
        }

        private static string LeetSpeech(string str)
        {
            char[] leetSpeech = str.ToCharArray();
            for (int i = 0; i < leetSpeech.Count(); i++)
            {
                switch (char.ToLower(leetSpeech[i]))
                {
                    case 'a':
                        leetSpeech[i] = '4';
                        break;
                    case 'e':
                        leetSpeech[i] = '3';
                        break;
                    case 'l':
                        leetSpeech[i] = '1';
                        break;
                    case 't':
                        leetSpeech[i] = '7';
                        break;
                }
            }
            return new string (leetSpeech);
        }
    }
}

