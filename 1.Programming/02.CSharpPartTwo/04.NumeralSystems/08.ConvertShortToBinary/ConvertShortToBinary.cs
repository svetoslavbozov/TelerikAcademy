using System;

class ConvertShortToBinary
{
    static void Main()
    {
        short number = short.Parse(Console.ReadLine());

        //Console.WriteLine(Convert.ToString(number, 2));

        string result = string.Empty;

        for (int i = 15; i >= 0; i--)
        {
            if ((number & (1 << i)) != 0)
            {
                Console.Write(1);
            }
            else
            {
                Console.Write(0);
            }
        }
        Console.WriteLine();
    }  
}

