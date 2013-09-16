/*Write a program to convert decimal numbers to their binary representation.
*/

using System;
using System.Text;

class ConvertDecimalToBinary
{
    static void Main()
    {
        Console.WriteLine("Enter number:");
        long number = int.Parse(Console.ReadLine());

        //string bin = Convert.ToString(number, 2); // short

        Console.WriteLine(ConvertToBinary(number));
    }
    static string ConvertToBinary(long number)
    {
        StringBuilder result = new StringBuilder();

        while (number > 0)
        {
            result.Insert(0, number % 2 == 0 ? 0 : 1);
            number /= 2;
        }

        return result.ToString();
    }
}

