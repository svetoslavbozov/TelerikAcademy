/*Write a program to convert hexadecimal numbers to their decimal representation.
*/

using System;

class ConvertHexadecimalToDecimal
{
    static void Main()
    {
        string hexadecimal = Console.ReadLine().ToUpper();

        //Console.WriteLine(Convert.ToInt32(hexadecimal,16)); //short

        Console.WriteLine(ConvertToDecimal(hexadecimal));
    }
    static long ConvertToDecimal(string hexadecimal)
    {
        long result = 0;

        for (int i = 0; i < hexadecimal.Length; i++)
        {
            if (hexadecimal[i] > 9)
            {
                result += (int)(hexadecimal[i] - 55) * (int)Math.Pow(16, hexadecimal.Length - 1 - i);
            }
            else
            {
                result += (int)hexadecimal[i] * (int)Math.Pow(16, hexadecimal.Length - 1 - i);
            }
        }

        return result;
    }
}

