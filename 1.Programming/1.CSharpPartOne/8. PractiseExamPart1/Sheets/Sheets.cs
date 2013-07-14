using System;

class Sheets
{
    static void Main()
    {
        int sheetsCount = int.Parse(Console.ReadLine());

        int[] A = {1024, 512, 256, 128, 64, 32, 16, 8,  4,  2, 1 };

        for (int i = 0; i <= 10; i++)
        {
            if (sheetsCount - A[i] >= 0)
            {
                sheetsCount -= A[i];
            }
            else
            {
                Console.WriteLine("A{0}", i);
            }
        }
        //for (int i = 0; i < 11; i++)
        //{
        //    int mask = 1;
        //    mask <<= i;
 
        //    if ((n & mask) == 0)
        //    {
        //        Console.WriteLine("A{0}", 10 - i);
        //    }
    }
}

