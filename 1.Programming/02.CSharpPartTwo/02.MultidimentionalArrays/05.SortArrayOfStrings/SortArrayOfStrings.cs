/*You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).*/

using System;
using System.Linq;

class SortArrayOfStrings
{
    static void Main()
    {
        Console.WriteLine("Enter array elements separated by comma:");
        string[] array = Console.ReadLine().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x.Length).ToArray();

        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
}

