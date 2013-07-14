using System;

class FindSignOfProduct
{
    static void Main()
    {
        Console.WriteLine("Enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        if ((firstNumber > 0) ^ (secondNumber > 0) ^ (thirdNumber > 0))
        {
            Console.WriteLine("+");
        }
        else
        {
            Console.WriteLine("-");
        }
    }
}

