/*14. Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. Use variable number of arguments.
 15*. Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.). Use generic method (read in Internet about generic methods in C#).
*/

using System;
using System.Linq;
class CalculationsWithIntArrays
{
    static void Main()
    {
        Console.WriteLine("Enter elements separated by comma: ");

        var sequence = Console.ReadLine().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(x => (x)).ToArray();

        Console.WriteLine(Min(sequence));
        Console.WriteLine(Max(sequence));
        Console.WriteLine(Sum(sequence));
        Console.WriteLine(Average(sequence));
        Console.WriteLine(Product(sequence));
    }
    static T Min<T>(T[] sequence)
    {
        return sequence.Min();
    }
    static T Max<T>(T[] sequence)
    {
        return sequence.Max();
    }
    static double Sum<T>(T[] sequence)
    {
        double result = 0;

        for (int i = 0; i < sequence.Length; i++)
        {
            result += Convert.ToDouble(sequence[i]);
        }

        return result;
    }
    static double Average<T>(T[] sequence)
    {
        return Convert.ToDouble(Sum(sequence)) / sequence.Length;
    }
    static double Product<T>(T[] sequence)
    {
        dynamic product = 1;

        for (int i = 0; i < sequence.Length; i++)
        {
            product *= Convert.ToDouble(sequence[i]);
        }

        return product;
    }
}

