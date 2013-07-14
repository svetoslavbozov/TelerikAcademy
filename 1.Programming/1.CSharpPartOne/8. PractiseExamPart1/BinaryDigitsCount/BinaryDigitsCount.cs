using System;

class BinaryDigitsCount
{
    static void Main()
    {
        char bit = char.Parse(Console.ReadLine());
        short numbersCount = short.Parse(Console.ReadLine());

        int[] results = new int[numbersCount];
        int index = 0;

        while (numbersCount > 0)
        {
            uint number = uint.Parse(Console.ReadLine());
            string digits = Convert.ToString(number, 2);
            int matchesCount = 0;

            foreach (char item in digits)
            {
                if (item == bit)
                {
                    matchesCount += 1;
                }
            }
            results[index] = matchesCount;
            index++;
            numbersCount--;          

        }
        foreach (var item in results)
        {
            Console.WriteLine(item);
        }
    }
}

