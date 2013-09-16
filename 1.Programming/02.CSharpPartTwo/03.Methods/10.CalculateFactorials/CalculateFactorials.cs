/*Write a program to calculate n! for each n in the range [1..100]. Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. */

using System;
using System.Linq;
using System.Collections.Generic;

class CalculateFactorials
{
    static void Main()
    {
        for (int n = 1; n <= 100; n++)
        {
            CalculateFactorial(n);
        }
    }
    static void CalculateFactorial(int n)
    {
        List<int> digits = new List<int> {1};

        for (int i = 1; i <= n; i++)
        {
            int reminder = 0;
            int currentLength = digits.Count(); // marks the end of next cicle before more elements are added

            for (int j = 0; j < currentLength; j++)
            {
                digits[j] = (digits[j]*i) + reminder;
                reminder = 0;

                if (digits[j] > 9)
                {
                    reminder = digits[j] / 10;

                    if (j == digits.Count() - 1)
                    {
                        //if its the end of the List, devide last number and add whats left to the List, until last is less than 10
                        while (digits[digits.Count() - 1] > 9)
                        {
                            digits.Add(digits[digits.Count() - 1] / 10);
                            digits[digits.Count() - 2] %= 10;
                        }
                        break;
                    }

                    digits[j] %= 10;
                }
            }
        }
        
        PrintResult(digits, n);
    }
    private static void PrintResult(List<int> digits, int n)
    {
        Console.Write("{0}! = ", n);
        for (int i = digits.Count() - 1; i >= 0; i--)
        {
            Console.Write(digits[i]);
        }
        Console.WriteLine();
    }
}

