using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class DancingBits
{
    static void Main(string[] args)
    {
        int k = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        StringBuilder concatenatedNumbers = new StringBuilder();

        for (int i = 0; i < n; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());

            concatenatedNumbers.Append(Convert.ToString(currentNumber, 2));
        }

        int counter = 0;

        StringBuilder sequence = new StringBuilder();
        char currentDigit = '1';

        for (int i = 0; i < concatenatedNumbers.Length; i++)
        {
            if (concatenatedNumbers[i] == currentDigit)
            {
                sequence.Append(concatenatedNumbers[i]);
            }
            else
            {
                if (sequence.Length == k)
                {
                    counter++;
                    currentDigit = concatenatedNumbers[i];
                    sequence.Clear();
                    sequence.Append(concatenatedNumbers[i]);
                }
                else
                {
                    currentDigit = concatenatedNumbers[i];
                    sequence.Clear();
                    sequence.Append(concatenatedNumbers[i]);
                }
            }
        }
        if (sequence.Length == k)
        {
            counter++;
        }
        
        Console.WriteLine(counter);
    }
}

