using System;

class PrintMinAndMaxOfSequence
{
    static void Main()
    {
        Console.WriteLine("Enter N:");
        int range = int.Parse(Console.ReadLine());

        int[] sequence = new int[range];

        for (int i = 0; i < range; i++)
        {
            Console.WriteLine("Enter number: ");
            sequence[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(sequence);

        Console.WriteLine("Min value: {0}", sequence[0]);
        Console.WriteLine("Max value: {0}", sequence[range - 1]);
    }
}

