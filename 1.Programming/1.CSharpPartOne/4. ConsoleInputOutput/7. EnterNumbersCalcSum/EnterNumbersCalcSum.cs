using System;

class EnterNumbersCalcSum
{
    static void Main()
    {
        Console.WriteLine("Enter the count of numbers: ");
        int numbersCount = int.Parse(Console.ReadLine());

        int summary = 0;

        while (numbersCount > 0)
        {
            Console.WriteLine("Enter number: ");
            int currentNumber = int.Parse(Console.ReadLine());
            summary += currentNumber;
            numbersCount--;
        }

        Console.WriteLine("The sum is " + summary);

    }
}

