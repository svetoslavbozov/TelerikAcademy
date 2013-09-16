/*Write a program that reads an array of integers and removes from it a minimal number of elements in such way that the remaining array is sorted in increasing order. Print the remaining sorted array. Example:
	{6, 1, 4, 3, 0, 3, 6, 4, 5}  {1, 3, 3, 4, 5}*/

using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

class PrintSortedSubarray
{
    static void Main()
    {
        Console.WriteLine("Enter array elements separated by comma: ");
        int[] array = Console.ReadLine().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(n => Convert.ToInt32(n)).ToArray();

        int bestSubsetIndex = SearchSubset(array);

        if (bestSubsetIndex == -1)
        {
            Console.WriteLine("Not Found");
        }
        else
        {
            PrintResult(array, bestSubsetIndex);
        }
    }

    private static int SearchSubset(int[] array)
    {
        int bestSubsetIndex = -1;
        int subsetsCount = (int)Math.Pow(2, array.Length) - 1;
        int bestLength = 0;

        StringBuilder buildSequence = new StringBuilder();

        for (int subsetIndex = subsetsCount; subsetIndex > 0; subsetIndex--)
        {
            for (int intArrayIndex = 1; intArrayIndex <= array.Length; intArrayIndex++)
            {
                if (((subsetIndex >> (intArrayIndex - 1)) & 1) == 1)
                {
                    buildSequence.Append(array[intArrayIndex - 1] + ",");
                }
            }

            int[] currentSequence = buildSequence.ToString().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(n => Convert.ToInt32(n)).ToArray();

            buildSequence.Clear();

            bool isFound = true;

            for (int i = 0; i < currentSequence.Length - 1; i++)
            {
                if (currentSequence[i] > currentSequence[i + 1])
                {
                    isFound = false;
                    break;
                }
            }

            if (isFound)
            {
                if (currentSequence.Length > bestLength)
                {
                    bestLength = currentSequence.Length;
                    bestSubsetIndex = subsetIndex;
                }
            }
        }
        return bestSubsetIndex;
    }
    private static void PrintResult(int[] array, int bestSubsetIndex)
    {
        for (int index = 1; index <= array.Length; index++)
        {
            if (((bestSubsetIndex >> (index - 1)) & 1) == 1)
            {
                Console.Write(array[index - 1]);

                if (index != array.Length)
                {
                    Console.Write(", ");
                }
            }
        }
        Console.WriteLine();
    }
}
