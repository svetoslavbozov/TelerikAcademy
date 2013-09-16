/* Write a program that shows the internal binary representation of given 32-bit signed floating-point number in IEEE 754 format (the C# type float). Example: -27,25  sign = 1, exponent = 10000011, mantissa = 10110100000000000000000.
 
    All explained in this video http://www.youtube.com/watch?v=iQFG7sAa7i4
 */
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your number:");
        float number = float.Parse(Console.ReadLine());

        string integer = Convert.ToString(Math.Abs((int)number),2); 
        string fraction = ConvertFractionToBinary(Math.Abs(number - (int)number));

        Console.Write("sign = {0}, ", number < 0 ? 1 : 0);
        Console.Write("exponent = {0}, ", FindExponent(integer, fraction));
        Console.WriteLine("mantisa = {0}", FindMantisa(integer, fraction));
    }

    //next method explained here http://cs.furman.edu/digitaldomain/more/ch6/dec_frac_to_bin.htm
    static string ConvertFractionToBinary(float fraction)
    {
        string binary = null;

        while (fraction != 0)
        {
            fraction *= 2;
            binary += (int)fraction;
            fraction -= (int)fraction;
        }
        return binary;
    }
    
    static string FindExponent(string integer, string fraction)
    {
        int exponent;

        if (integer.Length != 0)
        {
            exponent = integer.Length - 1;
        }
        else
        {
            exponent = -fraction.IndexOf('1') - 1; // if there is not integer part the power(exponent) will be negative
        }

        return Convert.ToString((127 + exponent), 2).PadLeft(8, '0'); 
    }
    static string FindMantisa(string integer, string fraction)
    {
        string mantisa;

        if (integer.Length != 0)
        {
            mantisa = integer.Substring(1) + fraction; // we dont write the first "1" so we take the substring after the first "1"
        }
        else
        {
            mantisa = fraction.Substring(fraction.IndexOf('1') + 1); // same here - if there is not integer part, add to the mantissa this part of the string that starts after first "1"
        }

        return mantisa.PadRight(23, '0'); // we have to add the zeros
    }
 
}