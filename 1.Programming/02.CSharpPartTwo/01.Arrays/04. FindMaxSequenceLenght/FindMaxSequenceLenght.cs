/*Write a program that finds the maximal sequence of equal elements in an array.
		Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.*/

using System;
using System.Linq;

class FindMaxSequenceLenght
{
    static void Main()
    {
        Console.WriteLine("Enter array elements separated by comma: ");
        int[] intArray = Console.ReadLine().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(n => Convert.ToInt32(n)).ToArray();

        int bestLenght = 1;
        int bestDigit = 0;
        int currentLenght = 1;

        for (int index = 0; index < intArray.Length - 1; index++)
        {
            if (intArray[index] == intArray[index + 1])
            {
                currentLenght++;

                if (currentLenght > bestLenght)
                {
                    bestLenght = currentLenght;
                    bestDigit = intArray[index];
                }
            }
            else
            {
                currentLenght = 1;
            }
        }

        for (int index = 0; index < bestLenght; index++)
        {
            Console.Write(bestDigit);
            if (index != bestLenght - 1)
            {
                Console.Write(", ");
            }
        }

        Console.WriteLine();
    }
}

