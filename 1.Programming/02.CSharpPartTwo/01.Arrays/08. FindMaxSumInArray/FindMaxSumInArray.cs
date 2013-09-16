/*Write a program that finds the sequence of maximal sum in given array. Example:
	{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}*/

using System;
using System.Linq;

class FindMaxSumInArray
{
    static void Main()
    {
        Console.WriteLine("Enter array elements separated by comma: ");
        int[] intArray = Console.ReadLine().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(n => Convert.ToInt32(n)).ToArray();

        int bestSum = int.MinValue;
        int currentSum = 0;
        int startIndex = 0;
        int currentStartIndex = 0;
        int endIndex = 0;

        for (int i = 0; i < intArray.Length; i++)
        {
            currentSum += intArray[i];

            if (intArray[i] > currentSum)
            {
                currentSum = intArray[i];
                currentStartIndex = i;
            }
            if (currentSum > bestSum)
            {
                bestSum = currentSum;
                startIndex = currentStartIndex;
                endIndex = i;
            }
        }

        for (int index = startIndex; index <= endIndex; index++)
        {
            Console.Write(intArray[index]);
            if (index != endIndex)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}

