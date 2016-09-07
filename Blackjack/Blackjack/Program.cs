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

        // Creates deck, and adds all the cards twice to the list "deck"
        private static void CreatingLargeDeck()
        {
            for (int colour = 0; colour < 4; colour++)
            {
                for (int number = 1; number < 14; number++)
                {
                    doubleDeck.Add(new Card(colour, number));
                    doubleDeck.Add(new Card(colour, number));
                }
            }
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
