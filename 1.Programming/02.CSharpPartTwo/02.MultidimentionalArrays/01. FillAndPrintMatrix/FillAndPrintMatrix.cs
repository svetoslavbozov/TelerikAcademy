/*Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
*/

using System;
class FillAndPrintMatrix
{

    static int counter = 1;
    static int size;
    static int[,] directions = { { 1, 0 }, { 0, 1 }, { -1, 0 }, { 0, -1 } };
    static int direction = 0;
    static void Main()
    {
        size = int.Parse(Console.ReadLine());

        FillUpDown();//task a
        FillUpDownAndReverse(); //task b
        FIllMatrixDiagonally(); // task c

        //task d
        bool[,] isVisited = new bool[size, size];
        int[,] matrix = new int[size, size];
        FillMatrixSpiral(0, 0, 1, isVisited, matrix);
        PrintMatrix(matrix);

    }
    static void FillUpDown() //task a)
    {
        int[,] matrix = new int[size, size];
        counter = 1;

        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                matrix[row, col] = counter;
                counter++;
            }
        }

        PrintMatrix(matrix);
    }
    static void FillUpDownAndReverse() //task b)
    {
        int[,] matrix = new int[size, size];
        counter = 1;

        for (int col = 0; col < matrix.GetLength(1); col++)
        {            
            if (col % 2 == 0) //even cols go up -> down
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    matrix[row, col] = counter;
                    counter++;
                }
            }
            else // odd cols go down -> up
            {
                for (int row = matrix.GetLength(0) - 1; row >= 0 ; row--)
                {
                    matrix[row, col] = counter;
                    counter++;
                }
            }            
        }

        PrintMatrix(matrix);
    }
    static void FIllMatrixDiagonally() //task c)
    {
        //set lower left corner to start
        int row = size - 1;
        int col = 0;

        counter = 0;

        int[,] matrix = new int[size, size];
        bool[,] isVisited = new bool[size, size];

        while (row >= 0) // fill left diagonals up to and including the midle diagonal
        {
            if (IsTraversable(row, col, size, isVisited))
            {
                counter++;
                matrix[row, col] = counter;
                isVisited[row, col] = true;

                row++;
                col++;
            }
            else
            {
                row--;
                col = 0;
            }
        }

        //set starting row and column for second part
        int currentCol = 1;
        row = 0;
        col = 1;

        while (counter <= size * size && col < size) // fill right diagonals
        {            
            if (IsTraversable(row, currentCol, size, isVisited))
            {
                counter++;
                matrix[row, currentCol] = counter;                
                isVisited[row, currentCol] = true;

                row++;
                currentCol++;
            }
            else
            {
                row = 0;
                col++;
                currentCol = col;
            }
        }

        PrintMatrix(matrix);
    }
    static void FillMatrixSpiral(int row, int col, int counter, bool[,] isVisited, int[,] matrix) //task d
    {
        matrix[row, col] = counter;
        isVisited[row, col] = true;        

        if (counter == size * size) // End recursion
        {
            return;
        }
        else
        {
            counter++;
            
            //set the next position
            int newRow = row + directions[direction, 0];
            int newCol = col + directions[direction, 1];

            // if not travesable search for while is next possible is found 
            while (!IsTraversable(newRow, newCol, size, isVisited)) 
	        {
                direction = ((direction + 1) % directions.GetLength(0));
                newRow = row + directions[direction, 0];
                newCol = col + directions[direction, 1];
	        }

            FillMatrixSpiral(newRow, newCol, counter, isVisited, matrix);
        }        
    }
    static bool IsTraversable(int row, int col, int size, bool[,] isVisited)
    {
        return ((row >= 0 && row < size) && (col >= 0 && col < size) && !isVisited[row, col]);
    }
    static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,3}", matrix[row,col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

