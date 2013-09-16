using System;

class DivideFactorials
{
    static void Main()
    {
        Console.WriteLine("Enter K and N such as 1 < K < N");

        Console.Write("K = ");
        int k = int.Parse(Console.ReadLine());

        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());

        int result = 1;

        if ((k > 1) && (k < n))
        {
            for (int i = k + 1; i <= n; i++)
            {
                result *= i;
            }
            Console.WriteLine(result);
        }
        else
        {
            throw new ArgumentOutOfRangeException("Invalid input");
        }

    }
}

