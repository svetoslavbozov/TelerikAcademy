using System;

class CheckSelectedBitInInteger
{
    static void Main()
    {
        Console.WriteLine("Enter number:");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter position:");
        int position = int.Parse(Console.ReadLine());

        bool result = ((number >> position) & 1) == 1;

        Console.WriteLine("Bit is 1 ? " + result) ;
    }
}

