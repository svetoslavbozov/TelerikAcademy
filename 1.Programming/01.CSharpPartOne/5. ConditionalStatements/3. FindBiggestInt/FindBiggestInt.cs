using System;

class FindBiggestInt
{
    static void Main()
    {
        Console.WriteLine("Enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        if (firstNumber < secondNumber)
        {
            firstNumber = secondNumber;

            if (firstNumber < thirdNumber)
            {
                firstNumber = thirdNumber;
            }
        }
        Console.WriteLine("Bigget number is " + firstNumber);

    }
}

