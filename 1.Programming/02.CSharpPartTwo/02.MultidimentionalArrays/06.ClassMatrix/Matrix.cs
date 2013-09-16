using System;
using System.Text;

public class Matrix<T>
{
    private readonly int row, col;
    private readonly T[,] matrix;

    public int Row
    {
        get { return this.row; }
    }

    public int Col
    {
        get { return this.col; }
    }

    public Matrix(int row, int col)
    {
        this.row = row;
        this.col = col;

        this.matrix = new T[row, col];
    }

    public T this[int row, int col]
    {
        get { return matrix[row, col]; }
        set { matrix[row, col] = value; }
    }

    public static Matrix<T> operator +(Matrix<T> matrix1, Matrix<T> matrix2)
    {
        if (matrix1.Row != matrix2.Row || matrix1.Col != matrix2.Col)
        {
            throw new ArgumentException("Invalid sizes");
        }

        Matrix<T> result = new Matrix<T>(matrix1.row, matrix1.col);

        for (int i = 0; i < matrix1.row; i++)
        {
            for (int j = 0; j < matrix1.col; j++)
            {
                result[i, j] = matrix1[i, j] + (dynamic)matrix2[i, j];
            }
        }
        return result;
    }

    public static Matrix<T> operator -(Matrix<T> matrix1, Matrix<T> matrix2)
    {
        if (matrix1.Row != matrix2.Row || matrix1.Col != matrix2.Col)
        {
            throw new ArgumentException("Invalid sizes");
        }

        Matrix<T> result = new Matrix<T>(matrix1.row, matrix1.col);

        for (int i = 0; i < matrix1.row; i++)
        {
            for (int j = 0; j < matrix1.col; j++)
            {
                result[i, j] = matrix1[i, j] - (dynamic)matrix2[i, j];
            }
        }
        return result;
    }

    public static Matrix<T> operator *(Matrix<T> matrix1, Matrix<T> matrix2)
    {
        if (matrix1.Col != matrix2.Row)
        {
            throw new ArgumentException("Inalid sizes");
        }

        Matrix<T> result = new Matrix<T>(matrix1.row, matrix2.col);

        for (int i = 0; i < result.row; i++)
        {
            for (int j = 0; j < result.col; j++)
            {
                for (int p = 0; p < matrix1.col; p++)
                {
                    result[i, j] += (dynamic)matrix1[i, p] * matrix2[p, j];
                }
            }
        }
        return result;
    }

    public override string ToString()
    {
        StringBuilder build = new StringBuilder();

        for (int i = 0; i < this.Row; i++)
        {
            for (int j = 0; j < this.Col; j++)
            {
                build.Append(this.matrix[i, j]);

                if (j == this.Col - 1)
                {
                    build.AppendLine();
                }
                else
                {
                    build.Append(", ");
                }
            }
        }
        return build.ToString();
    }
}

