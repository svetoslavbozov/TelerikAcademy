/*Write a program that reads a text file containing a square matrix of numbers and finds in the matrix an area of size 2 x 2 with a maximal sum of its elements. The first line in the input file contains the size of matrix N. Each of the next N lines contain N numbers separated by space. The output should be a single number in a separate text file. Example:
4
2 3 3 4
0 2 3 4			17
3 7 1 2
4 3 3 2
*/

using System;
using System.IO;
using System.Linq;

class ReadMatrixFromFile
{
    static void Main()
    {
        Console.WriteLine("Enter file path");
        string filePath = Console.ReadLine();

        int row = File.ReadAllLines(filePath).Length;
        int col = new StreamReader(filePath).ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;

        int[,] matrix = new int[row, col];

        matrix = ReadMatrixFromTextFile(filePath, matrix);
        Console.WriteLine(FindBestSumSubMatrix(matrix));
    }
    static int[,] ReadMatrixFromTextFile(string filePath, int[,] matrix)
    {
        using (StreamReader textFile = new StreamReader(filePath))
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
			{		
                int[] numbers = textFile.ReadLine() // read lines from file
                        .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(Int32.Parse)
                        .ToArray(); // convert each line to array of integers

                for (int j = 0; j < matrix.GetLength(1); j++)
			    {
			        matrix[i,j] = numbers[j];
			    }
            }
        }
        return matrix;
    }
    static int FindBestSumSubMatrix(int[,] matrix)
    {
        int bestSum = int.MinValue;
        int currentSum = int.MinValue;

        if (matrix.GetLength(0) > 1 && matrix.GetLength(1) > 1)
        {
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];

                    if (currentSum > bestSum)
                    {
                        bestSum = currentSum;
                    }
                }
            }
        }

        return bestSum;
    }
}

