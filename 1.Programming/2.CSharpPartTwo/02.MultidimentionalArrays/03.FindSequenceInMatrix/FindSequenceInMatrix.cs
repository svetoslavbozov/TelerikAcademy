/*We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbor elements located on the same line, column or diagonal. Write a program that finds the longest sequence of equal strings in the matrix.*/

using System;
class FindSequenceInMatrix
{
    static int bestLength = 0;
    static string bestString;

    static int[,] directions = { { 0, 1 }, { 1, 0 }, { 1, 1 }, { 1, -1 } };

    static void Main()
    {
        //read matrix information
        Console.WriteLine("Enter width:");
        int width = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter heigth:");
        int heigth = int.Parse(Console.ReadLine());

        string[,] matrix = new string[heigth, width];

        for (int row = 0; row < heigth; row++)
        {
            for (int col = 0; col < width; col++)
            {
                Console.Write("Element [{0},{1}] = ", row, col);
                matrix[row, col] = Console.ReadLine();
            }
        }

        // bool 3 dimentional array that tracks if a specified element is visited in specified direction
        bool[, ,] visited = new bool[matrix.GetLength(0), matrix.GetLength(1), directions.GetLength(0)];

        for (int row = 0; row < heigth; row++)
        {
            for (int col = 0; col < width; col++)
            {
                CheckAllDirections(matrix, visited, row, col);
            }
        }

        PrintResult(bestString, bestLength);
    }

    static void CheckAllDirections(string[,] matrix, bool[,,] visited, int row, int col)
    {
        for (int directionsIndex = 0; directionsIndex < directions.GetLength(0); directionsIndex++)
        {
            if (visited[row,col,directionsIndex]) // skip if current element is visited in current direction
            {
                continue;
            }
            else
            {
                int currentLength = 0;
                int nextRow = row;
                int nextCol = col;                

                //count consecutive equal elements in current direction
                while (IsTraversable(matrix, nextRow, nextCol) && matrix[row, col] == matrix[nextRow, nextCol])
                {
                    visited[nextRow, nextCol, directionsIndex] = true;
                    currentLength++;

                    nextRow += directions[directionsIndex, 0];
                    nextCol += directions[directionsIndex, 1];
                }

                if (currentLength > bestLength)
                {
                    bestLength = currentLength;
                    bestString = matrix[row, col];
                }
            }
        }
    }
    static bool IsTraversable(string[,] matrix, int row, int col)
    {
        return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
    }
    
    static void PrintResult(string bestString, int bestLength)
    {
        for (int i = 0; i < bestLength; i++)
        {
            Console.Write(bestString);

            if (i != bestLength - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}
/*test 1
4
3
ha
fifi
ho
hi
fo
ha
hi
xx
xxx
ho
ha
xx
*/

