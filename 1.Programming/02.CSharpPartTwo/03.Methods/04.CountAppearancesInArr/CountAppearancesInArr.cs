/*Write a method that counts how many times given number appears in given array. Write a test program to check if the method is working correctly.
*/

using System;
using System.Linq;

class CountAppearancesInArr
{
    static void Main()
    {
        Console.WriteLine("Enter array elements separated by comma:");
        int[] array = Console.ReadLine().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(x => Convert.ToInt32(x)).ToArray();

        Console.WriteLine("Enter searched value: ");
        int searchedValue = int.Parse(Console.ReadLine());

        int result = FindAppearances(array, searchedValue);
        Console.WriteLine(result > 0 ? result.ToString() : "Not Found");
    }
    static int FindAppearances(int[] array, int searchedValue)
    {
        var groups = array.GroupBy(x => x).OrderBy(g => g.Count());

        foreach (var group in groups)
        {
            if (group.Key == searchedValue)
            {
                return group.Count();
            }
        }
        return -1;
    }
}

