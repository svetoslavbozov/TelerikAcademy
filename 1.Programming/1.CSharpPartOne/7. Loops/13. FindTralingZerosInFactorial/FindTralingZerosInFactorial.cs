using System;
using System.Numerics;

class FindTralingZerosInFactorial
{
    static void Main()
    {
        Console.Write("Enter your number: ");
        int n = int.Parse(Console.ReadLine());

        int result = 0;

        for (int i = 5; i <= n; i *= 5)
        {
            result = result + (n / i);
        }

        Console.WriteLine("Result: " + result);
    }
}

