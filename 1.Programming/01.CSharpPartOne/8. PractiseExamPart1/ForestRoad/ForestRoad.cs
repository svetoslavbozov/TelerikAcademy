using System;

class ForestRoad
{
    static void Main()
    {
        int mapWidth = int.Parse(Console.ReadLine());

        for (int row = 0; row < mapWidth; row++)
        {
            for (int col = 0; col < mapWidth; col++)
            {
                if (col == row)
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

        for (int row = mapWidth - 1; row > 0; row--)
        {
            for (int col = 0; col < mapWidth; col++)
            {
                if (col == row-1)
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
    }
}

