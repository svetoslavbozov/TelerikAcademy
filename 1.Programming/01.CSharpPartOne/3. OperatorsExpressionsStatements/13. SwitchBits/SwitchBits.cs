using System;

class SwitchBits
{
    static void Main()
    {
        Console.WriteLine("Enter number:");
        int number = int.Parse(Console.ReadLine());

        int p = 3;
        int q = 24;
        int newNumber = number;

        for (int i = 0; i < 3; i++, p++, q++)
        {
            int mask1 = 1 << p;
            int mask2 = 1 << q;

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

