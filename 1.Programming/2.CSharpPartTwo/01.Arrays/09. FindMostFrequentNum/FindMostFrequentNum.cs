/*Write a program that finds the most frequent number in an array. Example:
	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)*/

using System;
using System.Linq;

class FindMostFrequentNum
{
    static void Main()
    {
        Console.WriteLine("Enter array elements separated by comma: ");
        int[] intArray = Console.ReadLine().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(n => Convert.ToInt32(n)).ToArray();

        var mostFrequentNum = intArray.GroupBy(item => item).OrderByDescending(g => g.Count()).Select(g => g).First();

        Console.WriteLine("{0}({1} times)", mostFrequentNum.Key, mostFrequentNum.Count());
    }
}

