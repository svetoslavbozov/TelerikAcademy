using System;

class PrintNumbersFromOneToN
{
    static void Main()
    {
        Console.WriteLine("Enter N:");
        int range = int.Parse(Console.ReadLine());

        for (int i = 1; i <= range; i++)
        {
            Console.WriteLine(i);
        }
    }
}

