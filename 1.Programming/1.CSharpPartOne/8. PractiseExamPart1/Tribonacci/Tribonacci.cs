using System;
using System.Numerics;

class Tribonacci
{
    static void Main()
    {
        BigInteger T1 = BigInteger.Parse(Console.ReadLine());
        BigInteger T2 = BigInteger.Parse(Console.ReadLine());
        BigInteger T3 = BigInteger.Parse(Console.ReadLine());

        int N = int.Parse(Console.ReadLine());
        BigInteger nextNumber = 0;

        for (int i = 0; i < N - 3; i++)
        {
            nextNumber = T1 + T2 + T3;
            T1 = T2;
            T2 = T3;
            T3 = nextNumber;            
        }
        Console.WriteLine(T3);
    }
}

