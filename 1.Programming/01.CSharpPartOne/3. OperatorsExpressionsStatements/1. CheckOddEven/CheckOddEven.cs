using System;

class CheckOddEven
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");

        int number = int.Parse(Console.ReadLine());

        bool result = number % 2 == 0;

        Console.WriteLine("Your number is " + (result ? "even" : "odd"));
    }
}

