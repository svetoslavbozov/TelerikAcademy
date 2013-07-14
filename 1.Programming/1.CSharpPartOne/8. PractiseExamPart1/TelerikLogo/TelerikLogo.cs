using System;

class TelerikLogo
{
    static void Main()
    {
        int logoSize = int.Parse(Console.ReadLine());

        int columns = ((2 * logoSize) - 1) + (logoSize - 1);

        for (int row = 0; row < logoSize - 1; row++)
        {
            for (int col = 0; col < columns; col++)
            {
                if (col == (logoSize/2) - row || col == columns - ((logoSize/2) + 1) + row)
                {
                    Console.Write("*");
                }
                else if (col == ((logoSize/2) + row) || col == columns -((logoSize/2) + row + 1))
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }
        
        
        
        
        
        // romb part
        for (int row = 0; row < logoSize; row++)
        {
            for (int col = 0; col < columns; col++)
            {
                if (col == (columns)/2 + row)
                {
                    Console.Write("*");
                }
                else if (col == (columns/2) - row)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }

        for (int row = logoSize -1; row > 0; row--)
        {
            for (int col = columns; col > 0; col--)
            {
                if (col == (columns) / 2 + row)
                {
                    Console.Write("*");
                }
                else if (col == (columns / 2) - (row - 2))
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }

        Console.WriteLine();
    }
}

