/*Write a method that reverses the digits of given decimal number. Example: 256  652*/

using System;
using System.Text;

class ReverseDigits
{
    static void Main()
    {
        Console.WriteLine("Enter number:");
        string number = Console.ReadLine().Replace("-", "").Replace(".", "");

        Console.WriteLine(Reverse(number));        
    }
    static decimal Reverse(string number)
    {
        StringBuilder result = new StringBuilder();

        char[] digits = number.ToString().ToCharArray();

        Array.Reverse(digits);

        result.Append(digits);

        return Convert.ToDecimal(result.ToString());
    }
}


