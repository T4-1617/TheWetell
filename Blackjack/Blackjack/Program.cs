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

        static int playerPoints = 0;
        static int playerScore = 0;

        static int dealerPoints = 0;

        static void Main(string[] args)
        {
            CreatingShoe();

            Console.WriteLine("Press enter to start the game:");
            Console.ReadLine();

            // Initializing some variables
            Card dealerCard = PickCard();
            dealerPoints += dealerCard.number;
            string dealerColour = SetColour(dealerCard.colour);
            string dealerNumber = SetValue(dealerCard.number);

            // Dealer draws a random card
            Console.WriteLine("Dealer drew the {0} of {1}", dealerNumber, dealerColour);
            Console.WriteLine("Dealer points: {0}", dealerPoints);

            // Continues game if there are more than 0 cards in shoe
            while (shoe.Count() > 0)
            {
                Console.WriteLine("Draw a card? (y/n)");
                string answer = Console.ReadLine();
                Console.WriteLine("\n");

                switch (answer)
                {
                    case "y":
                        //Draws a card to player
                        Card card = PickCard();
                        string colour = SetColour(card.colour);
                        string number = SetValue(card.number);

                        Console.WriteLine("You drew the {0} of {1}", number, colour);

                        // Changes card number (value) to 10 if number is over 10
                        if (card.number > 10)
                        {
                            card.number = 10;
                        }

                        // The Aces function
                        if (card.number == 1 && playerPoints < 11)
                        {
                            card.number = 11;
                        }

                        playerPoints += card.number;
                        Console.WriteLine("You have {0} points\n", playerPoints);

                        // Player win
                        if (playerPoints == 21)
                        {
                            Console.WriteLine("You won!");
                            playerScore += 3;
                            Console.WriteLine("Player score: {0}\n", playerScore);
                            playerPoints = 0;
                            break;
                        }

                        // Player lose
                        else if (playerPoints > 21)
                        {
                            Console.WriteLine("You lost.");
                            playerScore -= 1;
                            playerPoints = 0;
                            Console.WriteLine("Player score: {0}\n", playerScore);
                        }

                        break;

                    case "n":
                        // Draws card until points are higher than the players points
                        while (dealerPoints < playerPoints)
                        {
                            dealerCard = PickCard();
                            dealerPoints += dealerCard.number;

                            // Breaks the loop if dealer have more points than player
                            if (dealerPoints > playerPoints)
                            {
                                break;
                            }
                        }

                        // Dealer wins
                        if (dealerPoints >= playerPoints && dealerPoints <= 21)
                        {
                            Console.WriteLine("Dealer won!");
                            playerScore -= 1;
                            Console.WriteLine("Player score: {0}\n", playerScore);
                            playerPoints = 0;
                            dealerPoints = 0;
                            break;
                        }
                        // Dealer gets full and player wins
                        else
                        {
                            Console.WriteLine("You won!");
                            playerScore += 1;
                            Console.WriteLine("Player score: {0}\n", playerScore);
                            playerPoints = 0;
                            dealerPoints = 0;
                            break;
                        }
                }

                if (shoe.Count == 0)
                {
                    Console.WriteLine("Shoe is empty");
                    Console.WriteLine("Player score: {0}", playerScore);
                    CreatingShoe();
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