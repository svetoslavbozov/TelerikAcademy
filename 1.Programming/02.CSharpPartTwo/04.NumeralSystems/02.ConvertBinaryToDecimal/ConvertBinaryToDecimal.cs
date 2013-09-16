/*Write a program to convert binary numbers to their decimal representation.
*/

using System;

class ConvertBinaryToDecimal
{
    static void Main()
    {
        Console.WriteLine("Enter number:");
        string number = Console.ReadLine();

        //Console.WriteLine(Convert.ToInt32(number, 2)); // short

        Console.WriteLine(ConvertToDecimal(number));
    }
    static long ConvertToDecimal(string number)
    {
        long result = 0;

        for (int i = 0; i < number.Length; i++)
        {
            if (number[i] == '1')
            {
                result += (number[i] - '0') * (int)Math.Pow(2, number.Length - 1 - i);
            }
        }
        return result;
    }
}

