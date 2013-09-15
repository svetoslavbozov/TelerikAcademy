/*11. Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
		x2 + 5 = 1x2 + 0x + 5 
12. Extend the program to support also subtraction and multiplication of polynomials.*/

using System;
using System.Linq;

class Polinomials
{
    static void Main()
    {
        Console.WriteLine("Enter first polinomial coeficients:");
    decimal[] first = Console.ReadLine().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(x => Convert.ToDecimal(x)).ToArray();

        Console.WriteLine("Enter second polinomial coeficients:");
    decimal[] second = Console.ReadLine().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(x => Convert.ToDecimal(x)).ToArray();

    PrintResult(SumPolinomials(first, second));
    }
    static decimal[] SumPolinomials(decimal[] first, decimal[] second)
    {
        int maxLength = Math.Max(first.Length,second.Length);
        decimal[] result = new decimal[maxLength];

        for (int i = 0; i < maxLength; i++)
        {
            if (i < first.Length && i < second.Length)
            {
                result[i] = first[i] + second[i];
            }
            else if (i >= first.Length)
            {
                result[i] = second[i];
            }
            else if (i >= second.Length)
            {
                result[i] = first[i];
            }
        }
        return result;
    }
    static decimal[] MultiplyPolinomials(decimal[] first, decimal[] second)
    {
        int maxLength = Math.Max(first.Length, second.Length);
        decimal[] result = new decimal[maxLength];

        for (int i = 0; i < maxLength; i++)
        {
            if (i < first.Length && i < second.Length)
            {
                result[i] = first[i] * second[i];
            }
            else if (i >= first.Length)
            {
                result[i] = second[i];
            }
            else if (i >= second.Length)
            {
                result[i] = first[i];
            }
        }
        return result;
    }

    static decimal[] SubstractPolinomials(decimal[] first, decimal[] second)
    {
        int maxLength = Math.Max(first.Length, second.Length);
        decimal[] result = new decimal[maxLength];

        for (int i = 0; i < maxLength; i++)
        {
            if (i < first.Length && i < second.Length)
            {
                result[i] = first[i] - second[i];
            }
            else if (i >= first.Length)
            {
                result[i] = second[i];
            }
            else if (i >= second.Length)
            {
                result[i] = first[i];
            }
        }
        return result;
    }
    static void PrintResult(decimal[] array)
    {
        for (int i = array.Length - 1; i > 0; i--)
        {
            if (array[i] != 0)
            {
                Console.Write("{0}x^{1}", array[i], i);
            }

            if (i > 0 && array[0] != 0) //only for better formating of the otput
            {
                Console.Write(" + ");
            }
        }

        if (array[0] != 0) // print the last element witout X
        {
            Console.Write(array[0]);
        }

        Console.WriteLine(" = 0");
    }
}

