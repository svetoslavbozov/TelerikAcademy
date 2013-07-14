using System;

class Fire
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        int left = size / 2 - 1;
        int right = size / 2;

        for (int row = 0; row < size / 2; row++)
        {
            for (int col = 0; col < size; col++)
            {
                if ((left - row) == col || (right + row) == col)
                {
                    Console.Write("#");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }
        for (int row = 0; row < size / 4; row++)
        {
            for (int col = 0; col < size; col++)
            {
                if ((row == col || size - row - 1 == col))
                {
                    Console.Write("#");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine(new string('-', size));

        for (int i = 0; i < size/2; i++)
        {
            Console.WriteLine(new string('.', i) + new string('\\', (size / 2) - i) + new string('/', (size / 2) - i) + new string('.', i));
        }
    }
}

