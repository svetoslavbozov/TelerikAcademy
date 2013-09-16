using System;
using System.Collections.Generic;
using System.Numerics;

class TribonacciTriangle
{
    static void Main()
    {
        BigInteger T1 = BigInteger.Parse(Console.ReadLine());
        BigInteger T2 = BigInteger.Parse(Console.ReadLine());
        BigInteger T3 = BigInteger.Parse(Console.ReadLine());

        int N = int.Parse(Console.ReadLine());

        int coutnOfMembers = CalcNumberOfMembers(N);

        List<BigInteger> tribonacciSequence = MakeTtribonacciSequence(ref T1, ref T2, ref T3, coutnOfMembers);

        int nextMember = 0;

        for (int row = 1; row <= N; row++)
        {
            for (int col = 0; col < row; col++, nextMember++)
            {
                Console.Write(tribonacciSequence[nextMember]);
                Console.Write(" ");
            }
            Console.WriteLine();            
        }
    }

    static List<BigInteger> MakeTtribonacciSequence(ref BigInteger T1, ref BigInteger T2, ref BigInteger T3, int countOfMembers)
    {
        List<BigInteger> tribonacciSequence = new List<BigInteger>();

        tribonacciSequence.Add(T1);
        tribonacciSequence.Add(T2);
        tribonacciSequence.Add(T3);

        BigInteger nextNumber = 0;

        for (int i = 0; i < countOfMembers; i++)
        {
            nextNumber = T1 + T2 + T3;
            tribonacciSequence.Add(nextNumber);
            T1 = T2;
            T2 = T3;
            T3 = nextNumber;
        }
        return tribonacciSequence;
    }
    static int CalcNumberOfMembers(int n)
    {
        int result = 0;

        for (int i = 1; i <= n; i++)
        {
            result += i;
        }

        return result;
    }
}

