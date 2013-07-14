using System;

class FirTree
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int stars = 1;

        for (int row = 1; row < n; row++)
        {
            for (int col = (n - 1) - row; col > 0; col--)
            {
                Console.Write(".");
            }
            for (int i = 0; i < stars; i++)
            {
                Console.Write("*");
            }
            for (int col = (n - 1) - row; col > 0; col--)
            {
                Console.Write(".");
            }
            stars += 2;
            Console.WriteLine();
        }
        for (int i = 0; i < n-2; i++)
        {
            Console.Write(".");
        }
        Console.Write("*");
        for (int i = 0; i < n - 2; i++)
        {
            Console.Write(".");
        }
        Console.WriteLine();
    }
}

