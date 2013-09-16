using System;

class PrintMatrix
{
    static void Main()
    {
        Console.Write("Enter size of matrix N < 20: ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                Console.Write("{0} ", matrix[i, j - 1] = (j + i));
            }
            Console.WriteLine();
        }   
    }
}

