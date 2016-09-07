using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Program
    {
        static List<Card> doubleDeck = new List<Card>();

        static void Main(string[] args)
        {

        }

        // Templete for creating individual cards
        class Card
        {
            public int colour;
            public int number;

            public Card(int value, int num)
            {
                colour = value;
                number = num;
            }

        }
    }
}
