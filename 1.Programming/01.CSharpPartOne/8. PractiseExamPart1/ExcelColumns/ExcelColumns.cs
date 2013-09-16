using System;
using System.Numerics;

class ExcelColumns
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] letters = new int[n];

        for (int i = 0; i < n; i++)
        {
            char input = char.Parse(Console.ReadLine());

            letters[i] = input - 64; 
        }

        Array.Reverse(letters);

        BigInteger result = 0;

        for (int i = 0; i < n; i++)
        {
            result += letters[i] * CalcThePower(i);
        }

        Console.WriteLine(result);

    }
    static long CalcThePower(int index)
    {
        long power = 1;

        for (int i = 0; i < index; i++)
        {
            power *= 26;            
        }

        return power;
    }
}

