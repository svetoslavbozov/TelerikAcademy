using System;

class CheckIfDevisibleBy5And7
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");

        int number = int.Parse(Console.ReadLine());

        if (number % 5 == 0 && number % 7 == 0)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}

