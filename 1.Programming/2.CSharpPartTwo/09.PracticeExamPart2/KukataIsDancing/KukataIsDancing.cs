using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string[,] cube = {
                            {"RED", "BLUE", "RED"},
                            {"BLUE", "GREEN", "BLUE"},
                            {"RED", "BLUE", "RED"}
                         };

        int[] directionX = { 1, 0, -1, 0 };
        int[] directionY = { 0, -1, 0, 1 };

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string sequence = Console.ReadLine();

            int row = 1;
            int col = 1;
            int directionIndex = 0;

            foreach (var ch in sequence)
            {
                if (ch == 'L')
                {
                    directionIndex++;
                    directionIndex = (directionIndex == 4 ? 0 : directionIndex);
                }
                else if (ch == 'R')
                {
                    directionIndex--;
                    directionIndex = (directionIndex == -1 ? 3 : directionIndex);
                }
                else
                {
                    row += directionX[directionIndex];
                    col += directionY[directionIndex];
                }
                if (row == -1)
                {
                    row = 2;  // Checking for edge
                }
                if (row == 3)
                {
                    row = 0;  // Checking for edge
                }
                if (col == -1)
                {
                    col = 2; // Checking for edge
                }
                if (col == 3)
                {
                    col = 0; // Checking for edge
                }
            }
            Console.WriteLine(cube[row, col]);
        }
    }
}