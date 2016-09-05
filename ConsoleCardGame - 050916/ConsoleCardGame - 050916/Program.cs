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

            int cards = 52;

            CreateCards();
            RandomizeCards(cards);
            PrintCard();
        }

        static bool[,] deck = new bool[4, 13];
        static List<bool[,]> RandomizedDeck = new List<bool[,]>();
        static Random r = new Random();

        private static string CreateCards()
        {
            for (int value = 0; value < 4; value++)
            {
                for (int number = 0; number < 13; number++)
                {
                    deck[value, number] = false;
                }
            }
        }

        private static 

        /*
        private static  RandomizeCards(int cardsToRandomize)
        {
            //int maxCards = 52;
            //while (maxCards > cardsToRandomize)
            while(true)
            {
                int value = r.Next(0, 4);
                int number = r.Next(0, 13);

                if (deck[value, number] == false)
                {
                    deck[value, number] = true;
                    return 
                    //maxCards++;
                }
            }
        }
        /*

        private static string PrintCard(int value, int number)
        {
            string colour = string.Empty;
            switch (value)
            {
                case 0:
                    colour = "Spades";
                    break;
                case 1:
                    colour = "Clubs";
                    break;
                case 2:
                    colour = "Hearts";
                    break;
                case 3:
                    colour = "Diamonds";
                    break;

                default:
                    break;
            }
            return string.Format("You drew the {0} of {1}", number, colour);
        }

        /*
        private static string NameCards(int value)
        {
            switch (value)
            {
                case 0:
                    Console.WriteLine();
                    break;
                default:
                    break;
            }
        }
        */
    }
}
