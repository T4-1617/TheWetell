using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAug310816
{
    class Program
    {
        static void Main(string[] args)
        {

            int number1;
            int number2;

            Console.WriteLine("Enter a positive number:");
            number1 = GetValidNum();
            Console.WriteLine("Enter another positive number:");
            number2 = GetValidNum();
            Console.WriteLine("Enter an operator:");
            string ope = Console.ReadLine();

            int answer;

            switch (ope)
            {
                case "+":
                    answer = number1 + number2;
                    Console.WriteLine(answer);
                    break;

                case "-":
                    answer = number1 - number2;
                    Console.WriteLine(answer);
                    break;

                case "*":
                    answer = number1 * number2;
                    Console.WriteLine(answer);
                    break;
                case "/":
                    answer = number1 / number2;
                    Console.WriteLine(answer);
                    break;

                default:
                    break;
            }
        }

        private static int GetValidNum()
        {
            int num;
            bool isnum = int.TryParse(Console.ReadLine(), out num);
            if(isnum && num >= 0)
            {
                return num;
            }
            Console.WriteLine("Enter a valid number:");
            return GetValidNum();
        }
        
    }
} 
