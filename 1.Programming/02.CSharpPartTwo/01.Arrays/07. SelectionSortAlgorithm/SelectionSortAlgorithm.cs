/*Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. Use the "selection sort" algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.*/

using System;
using System.Linq;

class SelectionSortAlgorithm
{
    static void Main()
    {
        Console.WriteLine("Enter array elements separated by comma: ");
        int[] array = Console.ReadLine().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(x => Convert.ToInt32(x)).ToArray();

        for (int i = 0; i < array.Length; i++)
        {
            int minValueIndex = i;

            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[minValueIndex] > array[j])
                {
                    minValueIndex = j;
                }                
            }
            if (minValueIndex != i)
            {
                int local = array[i];
                array[i] = array[minValueIndex];
                array[minValueIndex] = local;
            }
        }

        Console.WriteLine();
        Console.WriteLine("Sorted array:");
        for (int index = 0; index < array.Length; index++)
        {
            Console.Write("{0}", array[index]);

            if (index != array.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}

