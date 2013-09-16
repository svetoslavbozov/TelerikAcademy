/*Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]). Each of the numbers that will be added could have up to 10 000 digits.*/

using System;

class SumArrayElements
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        string firstNum = Console.ReadLine();

        Console.WriteLine("Enter second number:");
        string secondNum = Console.ReadLine();

        PrintResult(SumDigits(firstNum, secondNum));
    }
    static int[] SumDigits(string first, string second)
    {        
        int[] result = new int[Math.Max(first.Length, second.Length)];
        int index = Math.Min(first.Length, second.Length);
        int firstLength = first.Length - 1;
        int secondLength = second.Length - 1;

        for (int i = 0; i < index; i++)
        {
            result[i] = first[firstLength - i] - '0' + second[secondLength - i] - '0';
        }

        if (firstLength < secondLength)
        {
            for (int i = index; i <= secondLength; i++)
            {
                result[i] = second[secondLength - i] - '0';
            }
        }
        else if (firstLength > secondLength)
        {
             for (int i = index; i <= firstLength; i++)
            {
                result[i] = first[firstLength - i] - '0';
            }
        }

        for (int i = 0; i < result.Length - 1; i++)
        {
            if (result[i] > 9)
            {
                result[i + 1] += (result[i] / 10);
                result[i] %= 10;
            }
        }

        Array.Reverse(result);
        return result;
    }
    static void PrintResult(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
        }
    }
}

