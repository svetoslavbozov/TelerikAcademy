using System;

class ChangeSelectedBitInInteger
{
    static void Main()
    {
        Console.WriteLine("Enter number:");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter position:");
        int position = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter bit value:");
        int bitValue = int.Parse(Console.ReadLine());

        if (((number >> position) & 1) == bitValue) // checks if the value we want is the same in the number
        {
            Console.WriteLine(number);
        }
        else
        {
            Console.WriteLine(number ^ (1 << position)); // switch with the desired bit value 
        }
    }
}

