using System;
using System.Linq;

class Lines
{
    static void Main()
    {
        int[,] matrix = new int[8, 8];

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

        int currentLenght = int.MinValue;
        int bestLenght = 0;
        int lines = 0;
        bool isCounting = false;

        for (int row = 0; row < 8; row++)
        {
            currentLenght = 0;
            isCounting = false;

            for (int col = 0; col < 8; col++)
            {
                if (matrix[row, col] == 1)
                {
                    isCounting = true;
                    currentLenght++;
                }
                if ((matrix[row, col] == 0 || col == 7) && isCounting)
                {
                    isCounting = false;

                    if (currentLenght > bestLenght)
                    {
                        bestLenght = currentLenght;
                        currentLenght = 0;
                        lines = 1;
                    }
                    else if (currentLenght < bestLenght)
                    {
                        currentLenght = 0;
                    }
                    else if (currentLenght == bestLenght)
                    {
                        lines++;
                        currentLenght = 0;
                    }
                }
            }
        }

        for (int col = 0; col < 8; col++)
        {
            currentLenght = 0;
            isCounting = false;

            for (int row = 0; row < 8; row++)
            {
                if (matrix[row, col] == 1)
                {
                    isCounting = true;
                    currentLenght++;
                }
                if ((matrix[row, col] == 0 || row == 7) && isCounting)
                {
                    isCounting = false;

                    if (currentLenght > bestLenght)
                    {
                        bestLenght = currentLenght;
                        currentLenght = 0;
                        lines = 1;
                    }
                    else if (currentLenght < bestLenght)
                    {
                        currentLenght = 0;
                    }
                    else if (currentLenght == bestLenght)
                    {
                        lines++;
                        currentLenght = 0;
                    }
                }
            }
        }
        if (bestLenght == 1)
        {
            lines /= 2;
        }

        Console.WriteLine(bestLenght);
        Console.WriteLine(lines);             
    }
}