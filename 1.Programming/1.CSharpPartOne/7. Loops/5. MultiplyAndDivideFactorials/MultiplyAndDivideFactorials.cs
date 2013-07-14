using System;

class MultiplyAndDivideFactorials
{
    static void Main()
    {
        Console.WriteLine("Enter K and N such as 1 < N < K");

        Console.Write("K = ");
        int k = int.Parse(Console.ReadLine());

        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());

        int result = 1;

        if ((k > n) && (n > 1))
        {
            for (int i = k, j = 1; i > k - n; i--, j++)
            {
                result *= i * j;
            }
            Console.WriteLine(result);
        }
        else
        {
            throw new ArgumentOutOfRangeException("Invalid input");
        }
    }
}

