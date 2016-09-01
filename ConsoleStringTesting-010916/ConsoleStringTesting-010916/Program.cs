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
            name = Console.ReadLine();

            //Prints the length of the string
            Console.WriteLine(name.Length);

            //Same thing as above, but removes the white space before counting the length
            Console.WriteLine(name.Replace(" ", string.Empty).Length);

            //Removes everything from the string after the first whitespace 
            string firstName;
            firstName = name.Split(' ').First();
            Console.WriteLine(firstName);

            //Removes everything before the last white space
            string lastName;
            lastName = name.Split(' ').Last();
            Console.WriteLine(lastName);

            //Takes the last name and puts it first also putting the first name last  
            string reverseNames = name;
            reverseNames = string.Format("{0}, {1}", lastName, firstName);
            Console.WriteLine(reverseNames);

            //Adds padding and splits the string into different lines
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

            //Uses method "ReverseNames"
            string lowercaseNames = name.ToLower();
            Console.WriteLine(ReverseNames(lowercaseNames));

            //Uses method "UpperLowerCase"
            Console.WriteLine(UpperLowerCase(name));

            //Uses method "LeetSpeech"
            Console.WriteLine(LeetSpeech(name));

        }

        //Method that reverse the string that is sent in
        private static string ReverseNames (string str)
        {
            char[] reverseNames = str.ToCharArray();
            Array.Reverse(reverseNames);
            return new string(reverseNames);
        }

        //Method that takes a normal string and makes every other letter uppercase
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

        //Mothod that converts a normal string of text to "leet" text
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

