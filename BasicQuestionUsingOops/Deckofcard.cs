using System;
namespace BasicQuestionUsingOops
{
    public class DeckOfCards
    {
        int[,] cards = new int[4, 13];

        public void allotCards(int playerNumber)
        {
            for (int i = 0; i < 9; i++)
            {
                allotOneCard(playerNumber);
            }
        }

        public void allotOneCard(int playerNumber)
        {
            Random random = new Random();

            int suit = random.Next(4);
            int rank = random.Next(13);

            if (cards[suit, rank] != 0)
            {
                allotOneCard(playerNumber);
            }
            else
            {
                cards[suit, rank] = playerNumber;
            }
        }
        public void print(int playerNumber)
        {
            for (int suit = 0; suit < 4; suit++)
            {
                for (int rank = 0; rank < 13; rank++)
                {
                    if (cards[suit, rank] == playerNumber)
                    {
                        Console.WriteLine(getSuit(suit) + " " + getRank(rank) + "\t");
                    }
                }
            }
            Console.WriteLine("\n");
        }

        String getRank(int rankNumber)
        {
            switch (rankNumber)
            {
                case 0:
                    return "2";
                case 1:
                    return "3";
                case 2:
                    return "4";
                case 3:
                    return "5";
                case 4:
                    return "6";
                case 5:
                    return "7";
                case 6:
                    return "8";
                case 7:
                    return "9";
                case 8:
                    return "10";
                case 9:
                    return "Jack";
                case 10:
                    return "Queen";
                case 11:
                    return "King";
                case 12:
                    return "Ace";
                default:
                    return "";
            }
        }

        String getSuit(int suitNumber)
        {
            switch (suitNumber)
            {
                case 0:
                    return "Clubs";
                case 1:
                    return "Diamonds";
                case 2:
                    return "Hearts";
                case 3:
                    return "Spades";
                default:
                    return "";
            }
        }

    }
}