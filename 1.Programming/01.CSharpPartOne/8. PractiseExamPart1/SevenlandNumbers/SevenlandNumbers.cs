using System;

class SevenlandNumbers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        number += 1;

        if (number % 10 >= 7)
        {
            number += 3;
        }
        if (number % 100 >= 70)
        {
            number += 30;
        }
        if (number %1000 >= 700)
        {
            number += 300;
        }

        Console.WriteLine(number);
    }
}

