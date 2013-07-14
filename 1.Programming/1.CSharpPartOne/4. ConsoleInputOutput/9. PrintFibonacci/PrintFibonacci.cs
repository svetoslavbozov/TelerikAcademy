using System;
using System.Numerics;

class PrintFibonacci
{
    static void Main()
    {
        BigInteger firstNumber = 0;
        BigInteger secondNumber = 1;

        Console.WriteLine(firstNumber);
        Console.WriteLine(secondNumber);

        for (int i = 0; i < 100; i++)
        {
            BigInteger nextNumber = firstNumber + secondNumber;
            Console.WriteLine(nextNumber);
            firstNumber = secondNumber;
            secondNumber = nextNumber;
        }
    }
}

