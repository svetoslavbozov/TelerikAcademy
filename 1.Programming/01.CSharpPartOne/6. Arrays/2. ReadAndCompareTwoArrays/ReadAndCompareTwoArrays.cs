/*Write a program that reads two arrays from the console and compares them element by element.*/

using System;

class ReadAndCompareTwoArrays
{
    static void Main()
    {
        Console.Write("Enter arrays lenght: ");
        int arraysLenght = int.Parse(Console.ReadLine());

        int[] firstArray = new int[arraysLenght];
        int[] secondArray = new int[arraysLenght];

        Console.WriteLine("Enter first array elements: ");

        for (int index = 0; index < arraysLenght; index++)
        {
            firstArray[index] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter second array elements: ");

        for (int index = 0; index < arraysLenght; index++)
        {
            secondArray[index] = int.Parse(Console.ReadLine());
        }

        bool isEqual = true;

        for (int index = 0; index < arraysLenght; index++)
        {
            if (firstArray[index] != secondArray[index])
            {
                isEqual = false;
                break;
            }
        }

        Console.WriteLine("Arrays are equal? {0}", isEqual);
    }
}

