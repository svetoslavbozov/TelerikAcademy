/*Write a method that returns the last digit of given integer as an English word. Examples: 512  "two", 1024  "four", 12309  "nine".*/

using System;

class SpellLastDigit
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        SpellDigit(num);
    }
    static void SpellDigit(int num)
    {
        string[] digits = { "one", "two", "three", "four", "five", "six", "seven", "eigth", "nine" };

        num = num % 10;

        Console.WriteLine("{0}", digits[num-1]);
    }
}

