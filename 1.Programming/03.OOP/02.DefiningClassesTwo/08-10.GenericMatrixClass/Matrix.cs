using System;

public class Matrix<T>  where T : struct
{
    private int height;
    private int width;
    private T[,] matrix;

    public Matrix(int width, int heigth)
    {
        this.matrix = new T[width, heigth];
        this.width = width;
        this.height = heigth;
    }

    public int Width
    {
        get { return width; }
    }
    
    public int Height
    {
        get { return height; }
    }
    
    public T this[int width, int height]
    {
        get { return this.matrix[width, height]; }
        set { this.matrix[width, height] = value; }
    }

    public static Matrix<T> operator +(Matrix<T> fistMatrix, Matrix<T> secondMatrix)
    {
        Matrix<T> newMatrix = new Matrix<T>(fistMatrix.Width, fistMatrix.Height);
        try
        {            
            for (int i = 0; i < fistMatrix.Width; i++)
            {
                for (int j = 0; j < fistMatrix.Height; j++)
                {
                    newMatrix[i, j] = (dynamic)fistMatrix[i, j] + secondMatrix[i, j];
                }
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
            throw ex;
        }
        return newMatrix;
    }

    public static Matrix<T> operator -(Matrix<T> fistMatrix, Matrix<T> secondMatrix)
    {
        Matrix<T> newMatrix = new Matrix<T>(fistMatrix.Width, fistMatrix.Height);
        try
        {
            for (int i = 0; i < fistMatrix.Width; i++)
            {
                for (int j = 0; j < fistMatrix.Height; j++)
                {
                    newMatrix[i, j] = (dynamic)fistMatrix[i, j] - secondMatrix[i, j];
                }
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
            throw ex;
        }
        return newMatrix;
    }

    public static Matrix<T> operator *(Matrix<T> fistMatrix, Matrix<T> secondMatrix)
    {
        Matrix<T> newMatrix = new Matrix<T>(fistMatrix.Width, fistMatrix.Height);
        try
        {
            for (int i = 0; i < fistMatrix.Width; i++)
            {
                for (int j = 0; j < fistMatrix.Height; j++)
                {
                    newMatrix[i, j] = (dynamic)fistMatrix[i, j] * secondMatrix[i, j];
                }
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
            throw ex;
        }
        return newMatrix;
    }

    public static bool operator true(Matrix<T> matrix)
    {
        for (int i = 0; i < matrix.Width; i++)
        {
            for (int j = 0; j < matrix.Height; j++)
            {
                if ((dynamic)matrix[i, j] != default(T))
                {
                    return true;
                }
            }
        }

        return false;
    }

    public static bool operator false(Matrix<T> matrix)
    {
        for (int i = 0; i < matrix.Width; i++)
        {
            for (int j = 0; j < matrix.Height; j++)
            {
                if ((dynamic)matrix[i, j] != default(T))
                {
                    return true;
                }
            }
        }
        return false;
    }
}

