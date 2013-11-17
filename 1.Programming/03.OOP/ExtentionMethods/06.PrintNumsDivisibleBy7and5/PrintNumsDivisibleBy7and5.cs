/*Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
*/

using System;
using System.Linq;

namespace _06.PrintNumsDivisibleBy7and5
{
    class PrintNumsDivisibleBy7and5
    {
        static void Main(string[] args)
        {
            int[] numbersArray = new int[] { 63, 2, 3, 42, 5, 6, 7, 8, 9, 35, 123, 235, 72, 21, 247, 16, 2, 6 };

            Console.WriteLine(String.Join(", ", (from number in numbersArray where number % 7 == 0 && number % 3 == 0 select number)));
            Console.WriteLine(String.Join(", ", numbersArray.Where(x => x % 7 == 0 && x % 3 == 0)));
        }
    }
}
