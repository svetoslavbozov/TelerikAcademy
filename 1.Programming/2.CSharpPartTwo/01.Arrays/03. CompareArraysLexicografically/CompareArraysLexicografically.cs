/*Write a program that compares two char arrays lexicographically (letter by letter).*/

using System;

class CompareArraysLexicografically
{
    static void Main()
    {
        Console.WriteLine("Enter first array elements separated by comma: ");
        char[] firstArray = Console.ReadLine().Replace(",", "").Replace(" ", "").ToCharArray();

        Console.WriteLine("Enter second array elements separated by comma: ");
        char[] secondArray = Console.ReadLine().Replace(",", "").Replace(" ", "").ToCharArray();

        if (firstArray.Length > secondArray.Length)
        {
            Console.WriteLine("Second array is smaller");
        }
        else if (firstArray.Length < secondArray.Length)
        {
            Console.WriteLine("First array is smaller");
        }
        else
        {
            for (int index = 0; index < firstArray.Length; index++)
            {
                //Compares the ASCII letters code (this is A-Za-z compare but there are other orders like aA-zZ, a-zA-Z etc.)
                if (firstArray[index] < secondArray[index])
                {
                    Console.WriteLine("First array is smaller");
                    break;
                }
                else if (firstArray[index] > secondArray[index])
                {
                    Console.WriteLine("Second array is smaller");
                    break;
                }
                else if (index == firstArray.Length - 1)                    
                {
                    Console.WriteLine("Arrays are equal");
                }
            }
        }
    }
}

