using System;

class CheckIfThirdDigitIs7
{
    static void Main()
    {
        Console.WriteLine("Enter number:");
        int number = int.Parse(Console.ReadLine());

        number /= 100;
        number %= 10;
        number = Math.Abs(number);

        Console.WriteLine("third digit " + (number == 7 ? "is " : "is not ") + "seven");
    }
}

