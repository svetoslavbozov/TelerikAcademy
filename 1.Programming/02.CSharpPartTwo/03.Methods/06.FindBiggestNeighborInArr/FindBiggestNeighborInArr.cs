/*Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1, if there’s no such element.*/

using System;
using System.Linq;

class FindBiggestNeighborInArr
{
    static void Main()
    {
         Console.WriteLine("Enter array elements separated by comma:");
        int[] array = Console.ReadLine().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(x => Convert.ToInt32(x)).ToArray();

       Console.WriteLine(FindBiggestNeighbor(array));
    }
    static int FindBiggestNeighbor(int[] array)
    {        
        for (int i = 1; i <= array.Length - 2; i++)
        {
            if ((array[i] > array[i - 1]) && (array[i] > array[i + 1]))
            {
                return i;
            }
        }   
        return -1;
    }
}

