/*We are given an array of integers and a number S. Write a program to find if there exists a subset of the elements of the array that has a sum S. Example:
	arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14  yes (1+2+5+6)
*/

using System;
using System.Linq;

class FindSubsetSum
{
    static void Main()
    {
        Console.WriteLine("Enter array elements separated by comma: ");
        int[] array = Console.ReadLine().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(n => Convert.ToInt32(n)).ToArray();

        Console.WriteLine("Enter searched summary:");
        int searchedSum = int.Parse(Console.ReadLine());

        int bestSubsetIndex = SearchSubsetSum(array, searchedSum);

        if (bestSubsetIndex == -1)
        {
            Console.WriteLine("Not Found");
        }
        else
        {
            PrintResult(array, bestSubsetIndex);
        }
    }

    private static void PrintResult(int[] array, int bestSubsetIndex)
    {
        Console.Write("Yes (");
        for (int index = 1; index <= array.Length; index++)
        {
            if (((bestSubsetIndex >> (index - 1)) & 1) == 1)
            {
                Console.Write(array[index - 1]);

                if (index != array.Length - 1)
                {
                    Console.Write("+");
                }
            }
        }
        Console.WriteLine(" \b)");
    }

    private static int SearchSubsetSum(int[] array, int searchedSum)
    {
        int subsetsCount = (int)Math.Pow(2, array.Length) - 1;
        int bestSubsetIndex = -1;
        int currentSum = 0;

        for (int subsetIndex = 1; subsetIndex <= subsetsCount; subsetIndex++)
        {
            currentSum = 0;
            int elementsAdded = 0;

            for (int arrayIndex = 1; arrayIndex <= array.Length; arrayIndex++)
            {
                if (((subsetIndex >> (arrayIndex - 1)) & 1) == 1)
                {
                    currentSum += array[arrayIndex - 1];
                    elementsAdded++;
                }
            }
            if (currentSum == searchedSum)
            {
                bestSubsetIndex = subsetIndex;
                break;
            }
        }
        return bestSubsetIndex;
    }
}
