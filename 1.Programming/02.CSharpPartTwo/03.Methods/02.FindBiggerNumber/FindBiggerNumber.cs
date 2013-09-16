/*Write a method GetMax() with two parameters that returns the bigger of two integers. Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().*/

using System;

class FindBiggerNumber
{
    static void Main()
    {
        Console.Write("Enter first num: ");
        int first = int.Parse(Console.ReadLine());

        Console.Write("Enter second num: ");
        int second = int.Parse(Console.ReadLine());

        Console.Write("Enter third num: ");
        int third = int.Parse(Console.ReadLine());

        int result = GetMax(first, second);
        result = GetMax(result, third);

        Console.WriteLine(result);
    }
    static int GetMax(int first, int second)
    {
        return Math.Max(first, second);
    }
}

