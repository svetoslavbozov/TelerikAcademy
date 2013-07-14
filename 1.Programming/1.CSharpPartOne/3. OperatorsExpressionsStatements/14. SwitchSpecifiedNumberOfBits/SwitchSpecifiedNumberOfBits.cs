using System;

class SwitchSpecifiedNumberOfBits
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number:");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter starting bit:");
        int startingBit = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter starting bit to switch with:");
        int startingSwitchBit = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter how many bits to switch:");
        int countOfBitsToSwitch = int.Parse(Console.ReadLine());

        int newNumber = number;

        if ((startingBit + countOfBitsToSwitch) > startingSwitchBit)
        {
            throw new ArgumentOutOfRangeException("Invalid input");
        }

        for (int i = 0; i < countOfBitsToSwitch; i++, startingBit++, startingSwitchBit++)
        {
            int mask1 = 1 << startingBit;
            int mask2 = 1 << startingSwitchBit;

            if ((((number & mask1) == 0) && ((number & mask2) == 0)) || (((number & mask2) != 0) && ((number & mask2) != 0)))
            {
                continue;
            }
            else
            {
                newNumber ^= mask1;
                newNumber ^= mask2;
            }
        }
        Console.WriteLine(newNumber);
    }
}

