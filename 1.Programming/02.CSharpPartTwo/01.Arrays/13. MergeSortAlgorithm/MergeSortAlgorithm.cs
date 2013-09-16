using System;
using System.Linq;

class MergeSortAlgorithm
{
    static void Main()
    {
        Console.WriteLine("Enter array elements separated by comma:");
        int[] array = Console.ReadLine().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(x => Convert.ToInt32(x)).ToArray();
        MergeSort(array, 0, array.Length - 1);
        Console.WriteLine();
    }
    static void MergeSort(int[] array, int minIndex, int maxIndex)
    {
        int elementsCount = maxIndex - minIndex;

        if (elementsCount <= 1)
        {
            return;
        }

        int midIndex = minIndex + elementsCount / 2;

        MergeSort(array, minIndex, midIndex);
        MergeSort(array, midIndex, maxIndex);

        int[] aux = new int[elementsCount];
        int min = minIndex;
        int max = midIndex;

        for (int i = 0; i < elementsCount; i++)
        {
            if (min == midIndex)
            {
                aux[i] = array[max++];
            }
            else if (max == maxIndex)
            {
                aux[i] = array[min++];
            }
            else if (array[max].CompareTo(array[min]) < 0)
            {
                aux[i] = array[max++];
            }
            else
            {
                aux[i] = array[min++];
            }
        }

        for (int k = 0; k < elementsCount; k++)
        {
            array[minIndex + k] = aux[k];
        }
    }
}
    

