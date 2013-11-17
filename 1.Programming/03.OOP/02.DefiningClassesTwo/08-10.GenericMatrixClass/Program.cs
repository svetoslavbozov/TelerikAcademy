/*
8. Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals). 
9.Implement an indexer this[row, col] to access the inner matrix cells.
10. Implement the operators + and - (addition and subtraction of matrices of the same size) and * for matrix multiplication. Throw an exception when the operation cannot be performed. Implement the true operator (check for non-zero elements).
*/
using System;

namespace _08_10.GenericMatrixClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix<int> firstMatrix = new Matrix<int>(4, 4);
            Matrix<int> secondMatrix = new Matrix<int>(4, 4);

            Matrix<int> sum = firstMatrix + secondMatrix;
            Matrix<int> product = firstMatrix * secondMatrix;
            Matrix<int> difference = firstMatrix - secondMatrix;

            Console.WriteLine();
        }
    }
}
