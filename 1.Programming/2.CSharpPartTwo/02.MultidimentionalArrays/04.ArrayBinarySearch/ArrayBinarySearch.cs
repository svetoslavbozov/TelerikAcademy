/*Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.*/

using System;
using System.Linq;

class ArrayBinarySearch
{
    static void Main()
    {
        Console.WriteLine("Enter array elements separated by comma:");
        int[] array = Console.ReadLine().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(x => Convert.ToInt32(x)).ToArray();

        Console.WriteLine("Enter value to compare:");
        int k = int.Parse(Console.ReadLine());

        Array.Sort(array);
        
        int index = Array.BinarySearch(array, k);

        // Array.BinarySearch Returns:
        //     The index of the specified value in the specified array, if value is found.
        //     If value is not found and value is less than one or more elements in array,
        //     a negative number which is the bitwise complement of the index of the first
        //     element that is larger than value. If value is not found and value is greater
        //     than any of the elements in array, a negative number which is the bitwise
        //     complement of (the index of the last element plus 1).

        // ..so..
        if (index > 0) // ..we need the [index - 1] element
        {
            Console.WriteLine(array[index - 1]);
        }
        else if (index == -1 || index == 0) //...there isnt smaller element
        {
            Console.WriteLine("Not Found");
        }
        else if (index < -1) // we need [index abs value minus 2] element
        {
            Console.WriteLine(array[Math.Abs(index) - 2]);
        }
    }
}

