using System;

class GreatestCommonDivisorEuclidAlgorithm
{
    static void Main()
    {
        Console.WriteLine("Enter two numbers: ");

        Console.Write("A = ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("B = ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.WriteLine(CalcGCD(firstNumber, secondNumber));
    }

    static int CalcGCD(int firstNumber, int secondNumber)
    {
        while (firstNumber != 0 && secondNumber != 0)
         {
             if (firstNumber > secondNumber)
             {
                 firstNumber %= secondNumber;
             }
             else
             {
                 secondNumber %= firstNumber;
             }
         }

        if (firstNumber == 0)
        {
            return secondNumber;
        }
        else
        {
            return firstNumber;
        }
    }
}


