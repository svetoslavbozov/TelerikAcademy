// solution by jasssonpet

using System;

class Program
{
    static int[] numbers = new int[8];
    static int[,] directions = new int[,] { { 1, 0 }, { 0, 1 }, { -1, 0 }, { 0, 1 } };
    static int direction = 0;
    static int length = 0;
    static int turns = 0;

    static bool IsTraversable(int row, int col)
    {
        return 0 <= row && row < numbers.Length && 0 <= col && col < numbers.Length && ((numbers[row] >> col) & 1) == 0;
    }

    static void DepthFirstSearch(int row, int col)
    {
        length++;

        if (row == 7 && col == 7)
        {
            Console.WriteLine(length + " " + turns);
        }
        else if (!IsTraversable(row, col))
        {
            Console.WriteLine("No {0}", length - 1);
        }
        else
        {
            int nextRow = row + directions[direction, 0];
            int nextCol = col + directions[direction, 1];

            if (!IsTraversable(nextRow, nextCol))
            {
                turns++;

                direction = ++direction % directions.GetLength(0);

                nextRow = row + directions[direction, 0];
                nextCol = col + directions[direction, 1];
            }

            DepthFirstSearch(nextRow, nextCol);
        }
    }

    static void Main()
    {
        for (int row = 0; row < 8; row++)
        {
            numbers[row] = int.Parse(Console.ReadLine());
        }

        DepthFirstSearch(0, 0);
    }
}