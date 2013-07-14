using System;
using System.Numerics;

class SumOfFibonacci
{
    static void Main()
    {
        Console.Write("Enter range: ");
        int range = int.Parse(Console.ReadLine());

        BigInteger firstNumber = 0;
        BigInteger secondNumber = 1;
        BigInteger sum = 0;

        for (int i = 1; i < range; i++)
        {
            BigInteger nextNumber = firstNumber + secondNumber;
            sum += secondNumber;
            firstNumber = secondNumber;
            secondNumber = nextNumber;
        }
        Console.WriteLine(sum);
    }
}

