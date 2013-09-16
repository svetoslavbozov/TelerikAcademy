using System;

class DrunkenNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int scoreM = 0;
        int scoreV = 0;

        for (int i = 0; i < n; i++)
        {
            string number = int.Parse(Console.ReadLine()).ToString().Replace("-", "");
            int length = number.Length;

            if (length % 2 == 0)
            {
                for (int M = 0, V = length - 1; M < length/2; M++, V--)
                {
                    scoreM += Convert.ToInt32(number[M].ToString());
                    scoreV += Convert.ToInt32(number[V].ToString());
                }
            }
            else
            {
                for (int M = 0, V = length - 1; M < length / 2 + 1; M++, V--)
                {
                    scoreM += Convert.ToInt32(number[M].ToString());
                    scoreV += Convert.ToInt32(number[V].ToString());
                }
            }
        }
        if (scoreV > scoreM)
        {
            Console.WriteLine("V {0}", scoreV - scoreM);
        }
        else if (scoreV < scoreM)
        {
            Console.WriteLine("M {0}", scoreM - scoreV);
        }
        else
        {
            Console.WriteLine("No {0}", scoreM + scoreV);
        }

        Console.WriteLine();
    }
}

