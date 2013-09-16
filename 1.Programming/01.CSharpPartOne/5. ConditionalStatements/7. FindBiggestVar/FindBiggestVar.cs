using System;

class FindBiggestVar
{
    static void Main()
    {
        int numbersCount = 5;
        int biggestNumber = int.MinValue;

        while (numbersCount > 0)
        {
            Console.WriteLine("Enter number: ");
            int currentNumber = int.Parse(Console.ReadLine());

            if (currentNumber > biggestNumber)
            {
                biggestNumber = currentNumber;
            }
            numbersCount--;
        }

        Console.WriteLine("Biggest number is " + biggestNumber);
    }
}

