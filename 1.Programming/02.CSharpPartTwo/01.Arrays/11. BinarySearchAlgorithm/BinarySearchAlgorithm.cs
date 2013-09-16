/*Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm*/

using System;
using System.Linq;

class BinarySearchAlgorithm
{
    static int searchedElement;
    static int[] array;
    static void Main()
    {
        Console.WriteLine("Enter array elements separated by comma:");        
        array = Console.ReadLine().Split(new string[] {","}, StringSplitOptions.RemoveEmptyEntries).Select(x => Convert.ToInt32(x)).ToArray();

        Array.Sort(array);

        Console.WriteLine("Enter searched element:");
        searchedElement = int.Parse(Console.ReadLine());

        int searchedIndex = BinarySearch(0, array.Length - 1);
        if (searchedIndex == 0)
        {
            Console.WriteLine("Not Found");
        }
        else
        {
            Console.WriteLine(searchedIndex);
        }        
    }
    static int BinarySearch(int minIndex, int maxIndex)
    {
        // test if array is empty
        if (maxIndex < minIndex)
        {
            // set is empty, so return value showing not found
            return 0;
        }
        else
        {
            // calculate midpoint to cut set in half
            int midIndex = FindMidPoint(minIndex, maxIndex);

            // three-way comparison
            if (array[midIndex] > searchedElement)
            {
                // key is in lower subset
                return BinarySearch(minIndex, midIndex - 1);
        }
            else if (array[midIndex] < searchedElement)
            {
                // key is in upper subset
                return BinarySearch(midIndex + 1, maxIndex);
            }
            else
            {
                // key has been found
                return midIndex;
            }
        }
    }
    static int FindMidPoint(int midIndex, int maxIndex)
    {
        return (midIndex + maxIndex) / 2;
    }
}


