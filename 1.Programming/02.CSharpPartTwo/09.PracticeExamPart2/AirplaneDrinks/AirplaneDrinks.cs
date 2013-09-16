using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace AirplaneDrinks
{
    class AirplaneDrinks
    {
        static void Main()
        {
            if (File.Exists("input1.txt"))
            {
                Console.SetIn(new StreamReader("input1.txt"));
            }

            int seats = int.Parse(Console.ReadLine());

            int teaCount = int.Parse(Console.ReadLine());

            int[] tea = new int[teaCount];

            for (int i = 0; i < teaCount; i++)
            {
                tea[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(Solve(seats, tea));
        }

        static long Solve(int seats, int[] tea)
        {
            long result = seats * 4;

            bool[] check = new bool[seats];

            int i;

            for (i = 0; i < tea.Length; i++)
            {
                check[tea[i] - 1] = true;
            }

            long lastTea = 0;
            long lastCoffee = 0;

            int countTea = 0;
            int countCoffee = 0;

            for (i = seats - 1; i >= 0; i--)
            {
                if (check[i])
                {
                    countTea++;
                    lastTea = Math.Max(lastTea, i + 1);
                }
                else
                {
                    countCoffee++;
                    lastCoffee = Math.Max(lastCoffee, i + 1);
                }
                if (countCoffee == 7)
                {
                    countCoffee = 0;
                    result += lastCoffee * 2;
                    result += 47;
                    lastCoffee = 0;
                }
                if (countTea == 7)
                {
                    countTea = 0;
                    result += lastTea * 2;
                    result += 47;
                    lastTea = 0;
                }
            }
            if (countCoffee != 0)
            {
                result += lastCoffee * 2; 
                result += 47;
            }
            if (countTea != 0)
            {
                result += lastTea * 2; 
                result += 47;
            }

            return result;
        }
    }
}
