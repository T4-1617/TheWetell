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
            Console.WriteLine("Enter a positive number:");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another positive number:");
            int number2 = int.Parse(Console.ReadLine());
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
    }
} 
