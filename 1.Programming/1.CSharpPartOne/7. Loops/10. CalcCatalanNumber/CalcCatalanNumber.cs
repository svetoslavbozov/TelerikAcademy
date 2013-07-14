
using System;

class CalcCatalanNumber
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine(CalcTheCatalanNumber(number));

    }

    static double CalcTheCatalanNumber(int number)
    {
        double result = 1;

        //the formula used is: the product of (n+k)/k for k between 2 and n and for for n >= 0
        for (int k = 2; k <= number; k++)
        {
            result *= (number + k) / (double)k;
        }

        return result;
    }
}

