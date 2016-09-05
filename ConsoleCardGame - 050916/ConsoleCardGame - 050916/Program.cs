using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCardGame___050916
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateCards();
        }

        private static void CreateCards()
        {
            bool[,] cards = null;

            for (int value= 0; value < 4; value++)
            {
                for (int number = 0; number < 13; number++)
                {
                    cards[value, number] = false;
                }
            }
        }


    }
}
