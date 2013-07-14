/*Write a program that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.*/

using System;

class FindMaxIncreasingSequenceInArray
{
    static void Main()
    {
        Console.WriteLine("Enter array elements separated by comma: ");
        string[] stringArray = Console.ReadLine().Split(',');

        int[] intArray = new int[stringArray.Length];

        for (int index = 0; index < stringArray.Length; index++)
        {
            intArray[index] = int.Parse(stringArray[index]);
        }

        int bestLenght = 1;
        int endingIndex = 0;
        int currentLenght = 1;

        for (int index = 0; index < intArray.Length - 1; index++)
        {
            if (intArray[index] + 1 == intArray[index + 1])
            {
                currentLenght++;

                if (currentLenght > bestLenght)
                {
                    bestLenght = currentLenght;
                    endingIndex = index + 1;
                }
            }
            else
            {
                currentLenght = 1;
            }
        }

        for (int index = endingIndex - (bestLenght-1); index <= endingIndex; index++)
        {
            Console.Write(intArray[index] + " ");
        }
        Console.WriteLine();
    }
}

