using System;

class CheckSelectedBitValueInInteger
{
    static void Main()
    {
        Console.WriteLine("Enter number:");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter position:");
        int position = int.Parse(Console.ReadLine());

        Console.WriteLine("Selected bit value is " + ((number >> position) & 1));
    }
}

