using System;

class UKFlag
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());

        for (int row = 0; row < size/2; row++)
        {
            for (int col = 0; col < size; col++)
            {
                if (col == row)
                {
                    Console.Write("\\");
                }
                else if (col == size/2)
                {
                    Console.Write("|");
                }
                else if (col == size - row - 1)
                {
                    Console.Write("/");
                }
                else
                {
                    Console.Write(".");
                }
            }

            Console.WriteLine();
        }

        for (int i = 0; i < size; i++)
        {
            if (i == size/2)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write("-");
            }
        }

        Console.WriteLine();

        for (int row = 0; row < size / 2; row++)
        {
            for (int col = 0; col < size; col++)
            {
                if (col == (size / 2 + 1) + row)
                {
                    Console.Write("\\");
                }
                else if (col == size / 2)
                {
                    Console.Write("|");
                }
                else if (col == (size / 2 - 1) - row)
                {
                    Console.Write("/");
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

