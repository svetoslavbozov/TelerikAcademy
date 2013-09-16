/*Write a method that calculates the number of workdays between today and given date, passed as parameter. Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.*/

using System;
using System.Linq;

class ReadAndSumArray
{
    static void Main()
    {
        Console.WriteLine("Enter int array elements separated by mpty space:");
        int[] array = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(x => Convert.ToInt32(x)).ToArray();

        int sum = 0;
        foreach (var item in array)
        {
            sum += item;
        }

        Console.WriteLine(sum);
    }
}

