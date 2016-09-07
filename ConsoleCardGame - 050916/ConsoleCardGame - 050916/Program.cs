using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCardGame___050916
{
    class Program
    {
        // Deck to hold cards
        static List<Card> deck = new List<Card>();
        static Random r = new Random();
        static int score;

        static void Main(string[] args)
        {
            CreateDeck();
            Console.WriteLine("Press ENTER for a card:");
            while (deck.Count > 0)
            {

                Console.ReadLine();
                Card card = PickCard();
                string number = GetNumberString(card.number);
                string colour = GetColour(card.value);
                Console.WriteLine("You drew the {0} of {1}!", number, colour);
                score += card.number;
                Console.WriteLine("Score: {0}", score);
                Console.WriteLine("Cards left: {0}", deck.Count);
            }
        }

        // Puts cards in the deck
        private static void CreateDeck()
        {
            for (int colour = 0; colour < 4; colour++)
            {
                for (int num = 1; num < 14; num++)
                {
                    deck.Add(new Card(colour, num));
                }
            }
        }
        // Merhod that picks out a card from the deck 
        private static Card PickCard()
        {
            int pos = r.Next(0, deck.Count);
            Card pickedCard = deck[pos];
            deck.RemoveAt(pos);
            return pickedCard;
        }
        // Gets the value from the card and sets its proper colour
        private static string GetColour(int value)
        {
            switch (value)
            {
                case 0:
                    return "Heart";
                case 1:
                    return "Spades";
                case 2:
                    return "Clubs";
                case 3:
                    return "Diamonds";
                default:
                    return string.Empty;
            }
        }
        // Gets the number from a card and sets its proper value, for example 11 = "Jack"
        private static string GetNumberString(int number)
        {
            switch (number)
            {
                case 1:
                    return "Ace";
                case 11:
                    return "Jack";
                case 12:
                    return "Queen";
                case 13:
                    return "King";
                default:
                    return number.ToString();
            }
        }
        // Creates card
        class Card
        {
            public int value;
            public int number;

            public Card(int colour, int num)
            {
                value = colour;
                number = num;
            }
        }

    }
}
