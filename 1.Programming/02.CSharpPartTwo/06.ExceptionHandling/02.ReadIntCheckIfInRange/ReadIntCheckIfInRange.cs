/*Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. If an invalid number or non-number text is entered, the method should throw an exception. Using this method write a program that enters 10 numbers:
			a1, a2, … a10, such that 1 < a1 < … < a10 < 100
*/

using System;

class ReadIntCheckIfInRange
{
    static void Main(string[] args)
    {
        const int MIN = 1;
        const int MAX = 100;
        const int COUNT = 10;

        Console.WriteLine("Enter 10 numbers between 1 and 100");

        for (int i = 0; i < COUNT; i++)
		{
             ReadNumber(MIN, MAX);
		}
    }

    public static void ReadNumber(int min, int max)
    {
        int number = int.Parse(Console.ReadLine());

        if (number <= min || number >= max)
        {
            Console.Error.WriteLine("Invalid number");
            throw new ArgumentException();
        }
    }
    
}

