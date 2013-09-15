using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TwoIsBetterThanOne
{
    class TwoIsBetterThanOne
    {
        static void Main(string[] args)
        {
            long[] range = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.None).Select(x => Convert.ToInt64(x)).ToArray();
            int[] numbers = Console.ReadLine().Split(new[] { "," }, StringSplitOptions.None).Select(x => Convert.ToInt32(x)).ToArray();
            int percent = int.Parse(Console.ReadLine());

            Task1(range);
            Task2(numbers, percent);
        }

        private static void Task1(long[] range)
        {
            int counter = 0;

            List<long> numbers = new List<long>() { 3, 5 };

            int min = 0;
            long max = (long)Math.Pow(10, 18);

            while (min < numbers.Count)
            {
                int right = numbers.Count;

                for (int i = min; i < right; i++)
                {
                    if (numbers[i] <= max)
                    {
                        numbers.Add((numbers[i] * 10) + 3);
                        numbers.Add((numbers[i] * 10) + 5);
                    }
                }

                min = right;
            }

            foreach (var item in numbers)
	        {
                if (item >= range[0] && item <= range[1] && CheckIfPalindrome(item))
                {
                    counter++;
                }  
            }            

            Console.WriteLine(counter);
        }
        private static void Task2(int[] numbers, int persent)
        {
            Array.Sort(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                int countOfSmallerOrEqualNumber = 0;

                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] >= numbers[j])
                    {
                        countOfSmallerOrEqualNumber++;
                    }
                }

                if (countOfSmallerOrEqualNumber >= numbers.Length * (persent / 100.0))
                {
                    Console.WriteLine(numbers[i]);
                    return;
                }
            }

            Console.WriteLine( numbers[numbers.Length - 1]);
            return;
        }

        static bool CheckIfPalindrome(long number)
        {
            string num = number.ToString();

            for (int i = 0; i < num.Length/2; i++)
            {
                if (num[i] != num[num.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}