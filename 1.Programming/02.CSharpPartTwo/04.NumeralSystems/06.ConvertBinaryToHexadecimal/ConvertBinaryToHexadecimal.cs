/*Write a program to convert binary numbers to hexadecimal numbers (directly).*/

using System;
using System.Text;

class ConvertBinaryToHexadecimal
{
    static void Main()
    {
        string binary = Console.ReadLine();

        Console.WriteLine(Convert.ToString(Convert.ToInt64(binary,2),16).ToUpper()); //cant make it more direct than this :)
    }
}

