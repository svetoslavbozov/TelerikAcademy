/*Write a program that compares two char arrays lexicographically (letter by letter).*/

using System;

class CompareCharArrays
{
    static void Main()
    {
        Console.WriteLine("Enter arrays lenght: ");
        int arraysLenght = int.Parse(Console.ReadLine());

        char[] firstArray = new char[arraysLenght];
        char[] secondArray = new char[arraysLenght];

        Console.WriteLine("Enter first array elements: ");

        for (int index = 0; index < arraysLenght; index++)
        {
            firstArray[index] = char.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter second array elements: ");

        for (int index = 0; index < arraysLenght; index++)
        {
            secondArray[index] = char.Parse(Console.ReadLine());
        }
        
        for (int index = 0; index < arraysLenght; index++)
        {
            if (firstArray[index] > secondArray[index])
            {
                Console.WriteLine("The first array is before second");
                break;
            }
            else if (firstArray[index] < secondArray[index])
            {
                Console.WriteLine("The second array is before first");
                break;
            }
            else
            {
                Console.WriteLine("Arrays are equal");
            }
        }
    }
}

