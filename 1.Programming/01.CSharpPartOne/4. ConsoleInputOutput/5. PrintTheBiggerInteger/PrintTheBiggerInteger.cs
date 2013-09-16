using System;

class PrintTheBiggerInteger
{
    static void Main()
    {
        Console.WriteLine("Enter a:");
        int intA = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter b:");
        int intB = int.Parse(Console.ReadLine());

        Console.WriteLine(Math.Max(intA, intB));
    }
}

