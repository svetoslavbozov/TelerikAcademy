using System;

class AngryBits
{
    static ushort[] numbers = new ushort[8];
    static int[,] directions = new int[,] { { -1, -1 }, { 1, -1 } };
    static int direction = 0;
    static int length = 0;
    static int score = 0;
    static int result = 0;

    static void Main()
    {
        for (int index = 0; index < 8; index++)
        {
            numbers[index] = ushort.Parse(Console.ReadLine());
        }

        SelectBird();

        if (CheckForPigsLeft())
        {
            Console.WriteLine(result + " Yes");
        }
        else
        {
            Console.WriteLine(result + " No");
        }
    }    

    static void SelectBird()
    {
        for (int col = 8; col < 16; col++)
        {
            for (int row = 0; row < 8; row++)
            {
                if (IsBitOne(row,col)/*in the sense isBird*/)
                {                    
                    SetBitToZero(row, col);
                    direction = 0;
                    MoveBird(row, col);

                    CalcResult(length, score);
                    length = 0;
                    score = 0;
                }
            }
        }
    }
    static void MoveBird(int row, int col)
    {

        if (IsTraversable(row,col) && IsBitOne(row, col)/*in sense isHit*/)
        {
            FindHits(row, col);
            return;
        }
        else if (row == 8 || col < 0)
        {
            return;
        }
        else
        {       
            int nextRow = row + directions[direction, 0];
            int nextCol = col + directions[direction, 1];
            
            if (!IsTraversable(nextRow, nextCol))
            {
                if (nextRow == 8 || nextCol < 0)
                {
                    return;
                }
                else
                {
                    direction = 1;

                    nextRow = row + directions[direction, 0];
                    nextCol = col + directions[direction, 1];
                }    
            }
            length++;
            MoveBird(nextRow, nextCol);
        }
    }

    static void FindHits(int row, int col)
    {
        for (int i = row - 1; i <= row + 1; i++)
        {
            for (int j = col - 1; j <= col + 1; j++)
            {
                if (IsInPigsField(i, j) && IsBitOne(i, j)/*in sense isPig*/)
                {
                    score++;
                    SetBitToZero(i, j);                    
                }
            }
        }
    }

    static bool IsTraversable(int row, int col)
    {
        return 0 <= row && row < 8 && 0 <= col && col < 16;
    }
    static bool IsInPigsField(int row, int col)
    {
        return 0 <= row && row < 8 && 0 <= col && col < 8;
    }

    static void SetBitToZero(int row, int col)
    {
        numbers[row] = Convert.ToUInt16(numbers[row] ^ (1 << col));
    }

    static bool IsBitOne(int row, int col)
    {
        return ((numbers[row] >> col) & 1) == 1;
    }

    static int CalcResult(int lenght, int score)
    {        
        return result += (length * score);   
    }

    static bool CheckForPigsLeft()
    {
        for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 8; col++)
            {
                if (IsBitOne(row,col)/*in sence isPig*/)
                {
                    return false;
                }
            }
        }
        return true;
    }
}

