using System;

class CompareIntegers
{
    static void Main()
    {
        Console.WriteLine("Enter first integer: ");
        int firstInt = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second integer: ");
        int secondInt = int.Parse(Console.ReadLine());

        if (firstInt > secondInt)
        {
            int switchingVariable = firstInt;
            firstInt = secondInt;
            secondInt = switchingVariable;
        }

        Console.WriteLine("First integer = {0} \nSecond integer = {1}", firstInt, secondInt);
    }
}

