using System;
using System.Linq;

class Pillars
{
    static void Main()
    {
        int[,] matrix = new int[8, 8];
        int counterLeft = 0;
        int counterRight = 0;

        for (int i = 0; i < 8; i++)
        {
            int number = int.Parse(Console.ReadLine());
            string s = Convert.ToString(number, 2); //Convert to binary in a string

            byte[] bits = s.PadLeft(8, '0') // Add 0's from left
                     .Select(c => byte.Parse(c.ToString())) // convert each char to int
                     .ToArray();

            for (int j = 0; j < 8; j++)
            {
                matrix[i, j] = bits[j];
            }
        }

        for (int pillar = 0; pillar < 8; pillar++)
        {
            counterLeft = 0;
            counterRight = 0;

            for (int col = 0; col < pillar; col++)
            {
                for (int row = 0; row < 8; row++)
                {
                    if (matrix[row,col] == 1)
                    {
                        counterLeft++;
                    }
                }
            }
            for (int col = 7; col > pillar; col--)
            {
                 for (int row = 0; row < 8; row++)
                {
                    if (matrix[row, col] == 1)
                    {
                        counterRight++;
                    }
                }
            }
            if (counterLeft == counterRight)
            {
                Console.WriteLine(7 - pillar);
                Console.WriteLine(counterLeft);
                break;
            }
            else if (pillar == 7)
            {
                Console.WriteLine("No");
            }
        }
    }
}

