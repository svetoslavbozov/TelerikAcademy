using System;

class BatGoikoTower
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        int columns = size * 2;

        int rightToLeft = size - 1;
        int leftToRight = size;

        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < columns; col++)
            { 
                if (col == rightToLeft)
                {
                    Console.Write("/");
                }
                else if (col == leftToRight)
                {
                    Console.Write("\\");
                }                
                else if ((col > rightToLeft && col < leftToRight) && (row == 1 || row == 3 || row == 6 || row == 10 || row == 15 || row == 21 || row == 28 || row == 36))
                {
                    Console.Write("-");
                }
                else
                {
                    Console.Write(".");
                }                
            }

            Console.WriteLine();
            leftToRight++;
            rightToLeft--;
        }
    }
}


