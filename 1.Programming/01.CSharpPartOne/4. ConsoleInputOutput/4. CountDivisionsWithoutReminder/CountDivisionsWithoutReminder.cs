using System;

class CountDivisionsWithoutReminder
{
    static void Main()
    {
        Console.WriteLine("Enter a:");
        int intA = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter b:");
        int intB = int.Parse(Console.ReadLine());

        int counter = 0;

        for (int number = intA; number <= intB; number++)
        {
            if (number % 5 == 0)
            {
                counter++;
            }
        }

        Console.WriteLine(counter);
    }
}

