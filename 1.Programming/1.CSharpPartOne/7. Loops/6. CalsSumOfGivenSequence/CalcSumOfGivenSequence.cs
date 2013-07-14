//Calculate the sum of the sequence S = 1 + 1!/X^1 + 2!/X^2 + … + N!/X^N

using System;

class CalcSumOfGivenSequence
{
    static void Main()
    {
        Console.WriteLine("Enter X and N: ");

        Console.Write("X = ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());

        double sum = 1;
        double factorial = 1;
        int power = 1;

        for (int i = 1; i <= n; i++)
        {
            power *= x;
            factorial *= i;
            sum += factorial / power;
        }
        Console.WriteLine(sum);
    }
}

