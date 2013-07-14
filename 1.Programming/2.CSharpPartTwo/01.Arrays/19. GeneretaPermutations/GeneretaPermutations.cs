/*Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N]. Example:
	n = 3  {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1}*/
//modified jassonpets` impelemtation https://github.com/jasssonpet/TelerikAcademy/blob/master/Programming/2.CSharpPartTwo/1.Arrays/19.Permutations/Program.cs

using System;

class GeneretaPermutations
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        bool[] isUsed = new bool[array.Length];
        MakePermutations(array, isUsed, 0);
    }
    static void MakePermutations(int[] array, bool[] isUsed, int index)
    {
        if (index == array.Length)
        {
            PrintResult(array);
            return;
        }

        for (int j = 0; j < array.Length; j++)
        {
            if (isUsed[j])
            {
                continue;
            }

            array[index] = j;

            isUsed[j] = true;
            MakePermutations(array, isUsed, index + 1);
            isUsed[j] = false;
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