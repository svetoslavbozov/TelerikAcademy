using System;

class PrintNamesOfCardsDeck
{
    static void Main()
    {
        string[] colors = { "Clubs", "Diamonts", "Hearts", "Spades" };
        string[] cards = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine(colors[i]);

            for (int j = 0; j < 13; j++)
            {
                Console.WriteLine(cards[j]);
            }
            Console.WriteLine();
        }
    }
}

