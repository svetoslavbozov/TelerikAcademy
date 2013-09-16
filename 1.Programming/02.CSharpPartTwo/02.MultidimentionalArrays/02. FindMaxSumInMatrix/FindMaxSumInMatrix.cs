/*Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.*/

using System;

class FindMaxSumInMatrix
{
    static void Main()
    {
        const int MIN_DIMENTIONS = 3;

        Console.WriteLine("Enter width:");
        int width = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter heigth:");
        int heigth = int.Parse(Console.ReadLine());

        int[,] matrix = new int[heigth, width];

        for (int row = 0; row < heigth; row++)
        {
            for (int col = 0; col < width; col++)
            {
                Console.Write("Element [{0},{1}] = ", row,col);
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
        }

        int bestSum = 0;
        int currentSum = 0;

            // check if dimentions are greater than 3
        if (heigth < MIN_DIMENTIONS || width < MIN_DIMENTIONS)
        {
            Console.WriteLine("Matrix 3 x 3 not Found");
        }
            // just sum the elements starting from top left corner of every posible 3x3 submatrix
        else
        {
            for (int row = 0; row <= heigth - 3; row++)
            {
                for (int col = 0; col <= width - 3; col++)
                {
                    currentSum = 0;

                    currentSum += matrix[row, col] + matrix[row + 1, col] + matrix[row + 2, col]
                        + matrix[row, col + 1] + matrix[row + 1, col + 1] + matrix[row + 2, col + 1]
                        + matrix[row, col + 2] + matrix[row + 1, col + 2] + matrix[row + 2, col + 2];

                    if (currentSum > bestSum)
                    {
                        bestSum = currentSum;
                    }
                }                
            }

            Console.WriteLine("Best 3 x 3 submatrix sum = {0}", bestSum);
        }
    }
}
/*test 1
5
4
1
2
3
4
5
6
7
8
9
10
11
12
13
14
15
16
17
18
19
20
 */
/* test 2 
2
2
1
2
3
4
*/
/* test 3
3
3
1
2
3
4
5
6
7
8
9
*/
  

