using System;

class ReadIntegersPrintSum
{
    static void Main()
    {
        Console.WriteLine("Enter a:");
        int intA = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter b:");
        int intB = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter c:");
        int intC = int.Parse(Console.ReadLine());

        Console.WriteLine("a + b + c = {0}", intA + intB + intC);
    }
}

