using System;

class CompareFloatingPointNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter first number");
        float firstNumber = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number");
        float secondNumber = float.Parse(Console.ReadLine());

        bool result = (firstNumber == secondNumber);

        Console.WriteLine(result);
    }
}

