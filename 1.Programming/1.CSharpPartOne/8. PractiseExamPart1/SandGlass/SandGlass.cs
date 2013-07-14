using System;

class SandGlass
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int row = 0; row < (n/2) + 1; row++)
        {
            for (int col = 0; col < row; col++)
            {
                Console.Write(".");
            }
            for (int stars = n - (row * 2); stars > 0; stars--)
            {
                Console.Write("*");
            }
            for (int col = 0; col < row; col++)
            {
                Console.Write(".");
            }
            Console.WriteLine();
        }

        for (int row = 1; row <= n / 2; row++)
        {
            for (int col = n/2 - row; col > 0; col--)
            {
                Console.Write(".");
            }
            for (int star = 1 + (row * 2); star > 0; star--)
            {
                Console.Write("*");
            }
            for (int col = n / 2 - row; col > 0; col--)
            {
                Console.Write(".");
            }
            Console.WriteLine();
        }
    }
}

