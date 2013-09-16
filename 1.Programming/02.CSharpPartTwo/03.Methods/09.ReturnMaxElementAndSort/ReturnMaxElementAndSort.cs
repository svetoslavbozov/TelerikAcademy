/*Write a method that return the maximal element in a portion of array of integers starting at given index. Using it write another method that sorts an array in ascending / descending order.*/

using System;
using System.Collections.Generic;
using System.Linq;

class ReturnMaxElementAndSort
{
    static void Main()
    {
        Console.WriteLine("Enter array elements separated by comma: ");
        int[] array = Console.ReadLine().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(x => Convert.ToInt32(x)).ToArray();

        Console.WriteLine("Enter Index:");
        int index = int.Parse(Console.ReadLine());

        if (index < 0 || index > array.Length)
        {
            throw new ArgumentOutOfRangeException("invalid Index");
        }

        Console.WriteLine("Max {0}", array[FindMaxElement(index,array)]);

        PrintResult(SortArrayDescending(array));
        Console.WriteLine();
        PrintResult(SortArrayAscending(array));
        Console.WriteLine();
    }
    static int FindMaxElement(int startIndex, int[] array)
    {
        int bestValue = int.MinValue;
        int bestIndex = 0;

        for (int i = startIndex; i < array.Length; i++)
        {
            if (bestValue < array[i])
            {
                bestValue = array[i];
                bestIndex = i;
            }
        }
        return bestIndex;
    }
    static int[] SortArrayDescending(int[] array)
    {
        int[] result = new int[array.Length];
        var intArray = new List<int>(array);
        int i = 0;

        while (intArray.Count() > 0)
        {
            int index = FindMaxElement(0, intArray.ToArray());

            result[i] = intArray[index];
            i++;
            intArray.RemoveAt(index);
        }
        return result;
    }

    static int[] SortArrayAscending(int[] array)
    {
        int[] result = new int[array.Length];
        var intArray = new List<int>(array);
        int i = result.Length - 1;

        while (intArray.Count() > 0)
        {
            int index = FindMaxElement(0, intArray.ToArray());

            result[i] = intArray[index];
            i--;
            intArray.RemoveAt(index);
        }
        return result;
    }
    static void PrintResult(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}

