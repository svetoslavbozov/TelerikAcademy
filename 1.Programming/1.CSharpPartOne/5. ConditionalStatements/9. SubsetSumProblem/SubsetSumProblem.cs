using System;
using System.Collections;
using System.Collections.Generic;

class SubsetSumProblem
{
    static void Main()
    {
        int[] numbers = new int[5];

        for (int index = 0; index < numbers.Length; index++)
        {
            Console.WriteLine("Enter number {0}: ", index + 1);
            numbers[index] = int.Parse(Console.ReadLine());
        }

        for (int i = 1; i < 32; i++)
        {
            string currSelection = Convert.ToString(i, 2).PadLeft(5, '0');
            int currSum = 0;

            if (currSelection[0] == '1')
            {
                currSum += numbers[0];
            }
            if (currSelection[1] == '1')
            {
                currSum += numbers[1];
            }
            if (currSelection[2] == '1')
            {
                currSum += numbers[2];
            }
            if (currSelection[3] == '1')
            {
                currSum += numbers[3];
            }
            if (currSelection[4] == '1')
            {
                currSum += numbers[4];
            }

            if (currSum == 0)
            {
                Console.WriteLine("There is subset sum 0");
                return;
            }
        }
        Console.WriteLine("There is not subset sum 0");
    }
//    int[] numbers = new int[5];
//int counter = 0;
//for (int i = 0; i < 5; i++)
//{
//numbers[i] = Convert.ToInt32(Console.ReadLine());
//}
//for (int i = 1; i < 32; i++)
//{
//int sum = 0;
//for (int j = 0; j < 5; j++)
//{
//sum += ((i >> j) & 1) * numbers[j];
//}
//if (sum == 0)
//{
//counter++;
//}
//}
//Console.WriteLine(counter + " Subset sums = 0"); 
}

