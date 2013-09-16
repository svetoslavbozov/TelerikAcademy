/*2.Write a program that generates and prints to the console 10 random values in the range [100, 200].
*/

using System;
class PrintRandowmValues
{
    static void Main()
    {
        const int LENGTH = 10;

        Random random = new Random();

        for (int i = 0; i < LENGTH; i++)
        {
            Console.WriteLine(random.Next(100,200));
        }
    }
}

