using System;

class QuadronacciRectangle
{
    static void Main()
    {
        long firstNumber = long.Parse(Console.ReadLine());
        long secondNumber = long.Parse(Console.ReadLine());
        long thirdNumber = long.Parse(Console.ReadLine());
        long fourthNumber = long.Parse(Console.ReadLine());

        int row = int.Parse(Console.ReadLine());
        int col = int.Parse(Console.ReadLine());

        long[] sequence = new long[row * col];

        sequence[0] = firstNumber;
        sequence[1] = secondNumber;
        sequence[2] = thirdNumber;
        sequence[3] = fourthNumber;

        for (int i = 4; i < row * col; i++)
        {
            long nextNumber = firstNumber + secondNumber + thirdNumber + fourthNumber;

            sequence[i] = nextNumber;

            firstNumber = secondNumber;
            secondNumber = thirdNumber;
            thirdNumber = fourthNumber;
            fourthNumber = nextNumber;
        }

        int index = 0;

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                Console.Write(sequence[index++]);

                if (j != col-1)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}

