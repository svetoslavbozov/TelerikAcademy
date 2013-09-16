using System;

class CheckTheThirdBit
{
    static void Main()
    {
        Console.WriteLine("Enter number:");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Third bit is " + (((number & 8) == 8)? "1" : "0"));
    }
}

