using System;

class Trapezoid
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int rows = 0; rows < n + 1; rows++)
        {
            for (int cols = 0; cols < (n * 2) - 1; cols++)
            {
                if (rows == 0)
                {
                    if (cols < n )
                    {
                        Console.Write(".");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                else if (rows == n)
                {
                    Console.Write("*");
                }
                else
                {
                    if (cols + rows == n)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
            }

            Console.WriteLine("*");
        }
    }
}

