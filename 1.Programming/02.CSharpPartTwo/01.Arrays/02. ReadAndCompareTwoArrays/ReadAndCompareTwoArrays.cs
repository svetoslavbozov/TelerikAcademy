/*Write a program that reads two arrays from the console and compares them element by element.*/

using System;
using System.Linq;

class ReadAndCompareTwoArrays
{
    static void Main()
    {
        Console.WriteLine("Enter first array elements separated by comma: ");
        int[] firstArray = Console.ReadLine().Split(new string[] {","}, StringSplitOptions.RemoveEmptyEntries).Select(n => Convert.ToInt32(n)).ToArray();

        Console.WriteLine("Enter second array elements separated by comma: ");
        int[] secondArray = Console.ReadLine().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(n => Convert.ToInt32(n)).ToArray();

        if (firstArray.Length != secondArray.Length)
        {
            Console.WriteLine("Arrays are not equal");
        }
        else
        {
            for (int index = 0; index < firstArray.Length; index++)
            {
                if (firstArray[index] != secondArray[index])
                {
                    Console.WriteLine("Arrays are not equal");
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

