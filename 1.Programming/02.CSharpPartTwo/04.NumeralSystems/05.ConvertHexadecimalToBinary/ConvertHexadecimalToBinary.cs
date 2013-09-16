/*Write a program to convert hexadecimal numbers to binary numbers (directly).
*/

using System;
using System.Text;
class ConvertHexadecimalToBinary
{
    static void Main(string[] args)
    {
        string hexadecimal = Console.ReadLine().ToUpper();

        Console.WriteLine(Convert.ToString(Convert.ToInt32(hexadecimal, 16), 2)); //short

        //Console.WriteLine(ConvertToDecimal(hexadecimal));
    }
    //static string ConvertToDecimal(string hexadecimal)
    //{
    //    StringBuilder result = new StringBuilder();

    //    for (int i = 0; i < hexadecimal.Length; i++)
    //    {
    //        if (hexadecimal[i] - '0' > 9)
    //        {
    //            result.Append(Convert.ToString((int)(hexadecimal[i] - 55), 2));
    //        }
    //        else if (i == 0)
    //        {
    //            result.Append((Convert.ToString(hexadecimal[i] - '0', 2)));
    //        }
    //        else
    //        {
    //            result.Append((Convert.ToString(hexadecimal[i] - '0', 2)).PadLeft(4,'0'));
    //        }
    //    }
    //    return result.ToString();
    //}
}

