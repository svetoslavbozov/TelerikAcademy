using System;
using System.Linq;

class QuickSortAlgorithm
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter array elements separated by comma:");
        string[] array = Console.ReadLine().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        
        // Sort the array
        Quicksort(array, 0, array.Length - 1);

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);

            if (i != array.Length - 1)
            {
                Console.Write(", ");
            }
        }

        Console.WriteLine();
    }
    public static void Quicksort(IComparable[] array, int minIndex, int maxIndex)
    {
        int min = minIndex;
        int max = maxIndex;

        IComparable pivot = array[(minIndex + maxIndex) / 2];

        while (min <= max)
        {
            while (array[min].CompareTo(pivot) < 0)
            {
                min++;
            }

            while (array[max].CompareTo(pivot) > 0)
            {
                max--;
            }

            if (min <= max)
            {
                // Swap
                IComparable tmp = array[min];
                array[min] = array[max];
                array[max] = tmp;

                min++;
                max--;
            }
        }

        // Recursive calls
        if (minIndex < max)
        {
            Quicksort(array, minIndex, max);
        }

        if (min < maxIndex)
        {
            Quicksort(array, min, maxIndex);
        }
    }
}


