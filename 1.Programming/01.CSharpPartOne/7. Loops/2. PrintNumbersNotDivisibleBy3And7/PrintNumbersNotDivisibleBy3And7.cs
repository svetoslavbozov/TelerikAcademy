using System;

class PrintNumbersNotDivisibleBy3And7
{
    static void Main()
    {
        Console.WriteLine("Enter N:");
        int range = int.Parse(Console.ReadLine());

        for (int i = 1; i <= range; i++)
        {
            if (!(i % 3 == 0 && i % 7 == 0))
            {
                Console.WriteLine(i);                
            }
        }
    }
}

