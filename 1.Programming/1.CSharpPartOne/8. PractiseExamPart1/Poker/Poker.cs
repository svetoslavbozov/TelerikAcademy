using System;
using System.Collections.Generic;
using System.Linq;

class Poker
{
    static void Main()
    {
        int[] cards = new int[5];

        for (int i = 0; i < 5; i++)
        {
            string input = (Console.ReadLine());

            switch (input)
            {
                case "J":
                    cards[i] = 11;
                    break;
                case "Q":
                    cards[i] = 12;
                    break;
                case "K":
                    cards[i] = 13;
                    break;
                case "A":
                    cards[i] = 14;
                    break;
                default:
                    cards[i] = Convert.ToInt32(input);
                    break;
            }
        }

        int pairs = 0;
        int triples = 0;
        int four = 0;
        int five = 0;

        var groups = cards.GroupBy(x => x);

        foreach (var group in groups)
        {
            if (group.Count() / 5 == 1)
            {
                five++;
            }

            else if (group.Count() / 4 == 1)
            {
                four++;
            }
            else if (group.Count() / 3 == 1)
            {
                triples++;
            }
            else if (group.Count() / 2 == 1)
            {
                pairs++;
            }
        }

        if (five == 1)
        {
            Console.WriteLine("Impossible");
        }
        else if (four == 1)
        {
            Console.WriteLine("Four of a Kind");
        }
        else if (triples == 1 && pairs == 1)
        {
            Console.WriteLine("Full House");
        }
        else if (triples == 1)
        {
            Console.WriteLine("Three of a Kind");
        }
        else if (pairs == 2)
        {
            Console.WriteLine("Two Pairs");
        }
        else if (pairs == 1)
        {
            Console.WriteLine("One Pair");
        }
        else
        {
            Array.Sort(cards);

            if (cards[0] == cards[1] - 1 && cards[0] == cards[2] - 2 && cards[0] == cards[3] - 3 && cards[0] == cards[4] - 4)
            {
                Console.WriteLine("Straight");
            }
            else
            {
                Console.WriteLine("Nothing");
            }
        }
    }
}