/*Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.*/


using System;

namespace _02.ExtensionMethodsForIEnumerable
{
    class ExtensionMethodsForIEnumerable
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine(numbers.Sum());
            Console.WriteLine(numbers.Product());
            Console.WriteLine(numbers.Average());
            Console.WriteLine(numbers.Max());
            Console.WriteLine(numbers.Min());
        }
    }
}
