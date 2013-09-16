using System;
using System.Collections.Generic;
using System.Text;

class TripleRotationOfDigits
{
    static void Main()
    {
        string number = Console.ReadLine();

        for (int i = 0; i < 3; i++)
        {
            if (number[number.Length - 1] != '0')
            {
                number = number.Insert(0, number[number.Length - 1].ToString());
                number = number.Remove(number.Length - 1);
            }
            else
            {
                number = number.Remove(number.Length - 1);
            }
        }

        Console.WriteLine(Convert.ToInt32(number));


        //int number = int.Parse(Console.ReadLine());

        //for (int i = 0; i < 3; i++)
        //{
        //    if (number > 9)
        //    {
        //        int lastDigit = number % 10;
        //        number /= 10;

        //        string result = lastDigit.ToString() + number.ToString();

        //        number = int.Parse(result);
        //    }
        //}
        //Console.WriteLine(number);
    }
}