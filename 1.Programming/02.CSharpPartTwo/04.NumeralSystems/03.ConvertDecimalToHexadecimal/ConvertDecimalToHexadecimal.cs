/*Write a program to convert decimal numbers to their hexadecimal representation.
*/

using System;
using System.Text;

class ConvertDecimalToHexadecimal
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine(Convert.ToString(number, 16)); //short

        Console.WriteLine(ConvertoToHexadecimal(number));
    }
    static string ConvertoToHexadecimal(int number)
    {
        StringBuilder result = new StringBuilder();

        while (number > 0)
        {
            if (number % 16 >= 10)
            {
                result.Insert(0,(char)('A' + ((number % 16) - 10)));
            }
            else
	        {
                result.Insert(0, number % 16);
	        }
            number /= 16;
        }

        return result.ToString();
    }
}

