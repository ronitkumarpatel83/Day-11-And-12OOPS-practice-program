using System;

namespace BasicQuestionUsingOops
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome to OOPS Programming");
                Console.WriteLine("Enter Number Between 1 to 9");
                Console.WriteLine("1.Deck of Card");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Welcome to Deck of Card Program");
                        DeckOfCards deckOfCards = new DeckOfCards();
                        for (int playerNumber = 1; playerNumber <= 4; playerNumber++)
                        {
                            deckOfCards.allotCards(playerNumber);
                            Console.WriteLine("Player " + playerNumber + " cards:");
                            deckOfCards.print(playerNumber);
                        }
                        break;
                    default:
                        Console.WriteLine("Please Enter Valid Key");
                        break;
                }
                Console.ReadLine();
            }
        }
    }    
}