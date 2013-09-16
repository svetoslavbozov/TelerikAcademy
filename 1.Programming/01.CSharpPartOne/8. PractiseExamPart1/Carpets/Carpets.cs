using System;

class Carpets
{
    static void Main()
    {
        int carpetWidth = int.Parse(Console.ReadLine());

        
        for (int col = 0; col < carpetWidth / 2; col++) 
        {
            for (int dots = (carpetWidth / 2) - (col + 1); dots > 0; dots--)
            {
                Console.Write(".");
            }

            bool space = true;

            for (int i = 0; i < col + 1; i++)
            {
                if (space)
                {                        
                    Console.Write("/");
                    space = false;
                }
                else
                {
                    Console.Write(" ");
                    space = true;
                }
            }

            for (int i = 0; i < col + 1; i++)
            {
                if (!space)
                {
                    Console.Write("\\");
                    space = true;
                }
                else
                {
                    Console.Write(" ");
                    space = false;
                }
            }
            for (int dots = (carpetWidth / 2) - (col + 1); dots > 0; dots--)
            {
                Console.Write(".");
            }
            Console.WriteLine();
        }

        for (int col = 0; col < carpetWidth / 2; col++)
        {
            for (int dots = 0; dots < col; dots++)
            {
                Console.Write(".");
            }

            bool space = true;

            for (int i = 0; i < (carpetWidth / 2) - col; i++)
            {
                if (space)
                {
                    Console.Write("\\");
                    space = false;
                }
                else
                {
                    Console.Write(" ");
                    space = true;
                }
            }
            for (int i = 0; i < (carpetWidth / 2) - col; i++)
            {
                if (!space)
                {
                    Console.Write("/");
                    space = true;
                }
                else
                {
                    Console.Write(" ");
                    space = false;
                }
            }
            for (int dots = 0; dots < col; dots++)
            {
                Console.Write(".");
            }
            Console.WriteLine();
            
        }
        
    }
}

