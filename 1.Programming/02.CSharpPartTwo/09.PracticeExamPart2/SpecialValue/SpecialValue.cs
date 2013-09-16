using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialValue
{
    class SpecialValue
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] array = new int[rows][];
            int index = 0;

            while (index < rows)
            {
                array[index] = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.None).Select(x => Convert.ToInt32(x)).ToArray();
                index++;
            }


            int steps = 1;
            int currentScore = 0;
            int bestScore = 0;

            int longestArray = 0;

            for (int i = 0; i < rows; i++)
			{
                if (array[i].Length > longestArray)
                {
                    longestArray = array[i].Length;
                }			 
			}

            for (int i = 0; i < array[0].Length; i++)
            {
                steps = 1;
                currentScore = 0;
                bool[,] isVisited = new bool[rows, longestArray];

                isVisited[0, i] = true;

                if (array[0][i] < 0)
                {
                    currentScore += steps + Math.Abs(array[0][i]);
                }
                else
                {
                    int row = 1;

                    if (rows == 1)
                    {
                        row = 0;
                    }

                    int col = array[0][i];

                    while (array[row][col] >= 0 && !isVisited[row,col])
                    {
                        steps++;
                        isVisited[row, col] = true;
                        col = array[row][col];
                        row = (row + 1) % rows;

                        if (rows == 1)
                        {
                            row = 0;
                        }
                    }

                    if (array[row][col] > 0)
                    {
                        currentScore += 1 + steps;
                    }
                    else
                    {
                        currentScore += 1 + Math.Abs(array[row][col]) + steps;
                    }
                }

                if (currentScore > bestScore)
                {
                    bestScore = currentScore;
                }
            }

            Console.WriteLine(bestScore);
        }
    }
}
