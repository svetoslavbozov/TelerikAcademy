/*Write a program that finds all prime numbers in the range [1...10 000 000]. Use the sieve of Eratosthenes algorithm*/

using System;
using System.Linq;

class FindPrimeNumbers
{
    static void Main()
    {
        int length = 10000000;
        bool[] array = new bool[length];

        for (int i = 2; i <= Math.Sqrt(length); i++)
        {
            if (!array[i])
            {
                for (int j = i * i; j < length; j += i)
                {
                    array[j] = true;
                }
            }
        }
        //for (int i = 2; i < length; i++)
        //{
        //    if (!array[i])
        //    {
        //        Console.Write(i);
        //        if (i != length - 1)
        //        {
        //            Console.Write(", ");
        //        }
        //    }            
        //}
        //Console.WriteLine();
    }
}

