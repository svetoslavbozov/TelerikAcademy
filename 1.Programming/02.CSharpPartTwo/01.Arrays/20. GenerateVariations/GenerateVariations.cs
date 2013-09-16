/*Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N]. Example:
	N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}*/
//jassonpet implementation https://github.com/jasssonpet/TelerikAcademy/blob/master/Programming/2.CSharpPartTwo/1.Arrays/20.Variations/Program.cs

using System;

class GenerateVariations
{
    static void Main()
    {
        Console.WriteLine("Enter number for N :");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter number for K :");
        int k = int.Parse(Console.ReadLine());

        int[] array = new int[k];

        MakeVariations(array, n, 0);
    }
    static void MakeVariations(int[] array, int n, int currentIndex)
    {
        if (currentIndex == array.Length)
        {
            PrintResult(array);
            return;
        }

        for (int j = 0; j < n; j++)
        {
            array[currentIndex] = j;

            MakeVariations(array, n, currentIndex + 1);
        }
    }
    static void PrintResult(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + 1);

            if (i == array.Length - 1)
            {
                Console.WriteLine();
            }
            else
            {
                Console.Write(" ");
            }
        }
    }
}

