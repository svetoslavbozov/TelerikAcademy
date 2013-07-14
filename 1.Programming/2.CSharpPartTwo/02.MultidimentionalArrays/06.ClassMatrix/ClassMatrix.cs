/** Write a class Matrix, to holds a matrix of integers. Overload the operators for adding, subtracting and multiplying of matrices, indexer for accessing the matrix content and ToString().
*/

using System;  
class ClassMatrix
{
    const int SIZE = 5;
    static void Main()
    {
        Matrix<int> matrix1 = new Matrix<int>(SIZE, SIZE);
        Matrix<int> matrix2 = new Matrix<int>(SIZE, SIZE);

        int number = 0;

        for (int i = 0; i < SIZE; i++)
        {
            for (int j = 0; j < SIZE; j++)
            {
                matrix1[i, j] = number++;
                matrix2[i, j] = number * 2;
            }
        }

        Matrix<int> summary = matrix1 + matrix2;
        Matrix<int> difference = matrix1 - matrix2;
        Matrix<int> product = matrix1 * matrix2;

        Console.WriteLine(summary.ToString());
        Console.WriteLine(difference.ToString());
        Console.WriteLine(product.ToString());
    }

}



