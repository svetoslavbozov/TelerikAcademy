using System;
using System.Linq;

class OddNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        long[] numbers = new long[n];

        for (int i = 0; i < n; i++)
        {
            numbers[i] = long.Parse(Console.ReadLine());
        }

        var groups = numbers.GroupBy(x => x);

        foreach (var group in groups)
        {
            if (group.Count() % 2 != 0)
            {
                Console.WriteLine(group.ElementAt(0));
                break;
            }
        }
    }
}

