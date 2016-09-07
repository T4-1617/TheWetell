using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Program
    {
        static List<Card> shoe = new List<Card>();
        static Random r = new Random();
        static int score = 0;

        static void Main(string[] args)
        {
            CreatingShoe();

            Console.WriteLine("Press enter to start the game:");
            Console.ReadLine();
            while (shoe.Count() > 0)
            {
                Console.WriteLine("Draw a card? (y/n)");
                string answer = "y";

                switch (answer)
                {
                    case "y":
                        Card card = PickCard();

                        string colour = SetColour(card.colour);
                        string number = SetValue(card.number);
                        Console.WriteLine("You drew the {0} of {1}", number, colour);
                        if (card.number > 10)
                        {
                            card.number = 10;
                        }
                        if (card.number == 1)
                        {
                            if (score < 11)
                            {
                                card.number = 10;
                            }
                        }
                        score += card.number;
                        Console.WriteLine("Your score is {0}", score);

                        if (score == 21)
                        {
                            Console.WriteLine("You won!");
                            return;
                        }
                        else if (score > 21)
                        {
                            Console.WriteLine("You lost.");
                            score = 0;
                        }
                        break;
                    case "n":
                        Console.WriteLine("Your score: {0}", score);
                        score = 0;
                        break;

                    default:
                        break;
                }

                if (shoe.Count == 0)
                {
                    Console.WriteLine("Shoe is empty");
                    break;
                }
                Console.WriteLine("Cards left: {0}\n", shoe.Count);
            }

        }
        // Creates deck, and adds all the cards twice to the list "deck"
        private static void CreatingShoe()
        {
            for (int colour = 0; colour < 4; colour++)
            {
                for (int number = 1; number < 14; number++)
                {
                    shoe.Add(new Card(colour, number));
                    shoe.Add(new Card(colour, number));
                }
            }
        }
        // Picks a random card from the large deck
        private static Card PickCard()
        {
            int deckPosition = r.Next(0, shoe.Count);
            Card pickCard = shoe[deckPosition];
            shoe.RemoveAt(deckPosition);
            return pickCard;
        }
        // Sets colours to strings with the colourname 
        private static string SetColour(int colour)
        {
            switch (colour)
            {
                case 0:
                    return "Diamonds";
                case 1:
                    return "Spades";
                case 2:
                    return "Clubs";
                case 3:
                    return "Hearts";
                default:
                    return null;
            }
        }
        // Sets the value into a string 
        private static string SetValue(int number)
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