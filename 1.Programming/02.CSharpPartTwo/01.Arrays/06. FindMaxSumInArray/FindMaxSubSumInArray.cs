/*Write a program that reads two integer numbers N and K and an array of N elements from the console. Find in the array those K elements that have maximal sum.*/

using System;

class FindMaxSumInArray
{
    static void Main()
    {
        Console.WriteLine("Enter array lenght:");
        int arrayLenght = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter subarray lenght:");
        int subArrayLenght = int.Parse(Console.ReadLine());

        int[] intArray = new int[arrayLenght];

        Console.WriteLine("Enter array members");

        for (int index = 0; index < arrayLenght; index++)
        {
            intArray[index] = int.Parse(Console.ReadLine());
        }

        int subsetsCount = (int)Math.Pow(2, arrayLenght) - 1;
        int sum = int.MinValue;
        int bestSubsetIndex = 0;
        int currentSum = 0;

        for (int subsetIndex = 1; subsetIndex <= subsetsCount; subsetIndex++)
        {
            currentSum = 0;
            int elementsAdded = 0;

            for (int intArrayIndex = 1; intArrayIndex <= arrayLenght; intArrayIndex++)
            {
                if (((subsetIndex >> (intArrayIndex - 1)) & 1) == 1)
                {
                    currentSum += intArray[intArrayIndex - 1];
                    elementsAdded++;
                }
            }
            if (currentSum > sum && elementsAdded == subArrayLenght)
            {
                bestSubsetIndex = subsetIndex;
                sum = currentSum;
            }
        }

        for (int intArrayIndex = 1; intArrayIndex <= arrayLenght; intArrayIndex++)
        {
            if (((bestSubsetIndex >> (intArrayIndex - 1)) & 1) == 1)
            {
                Console.Write(intArray[intArrayIndex - 1] + " ");
            }
        }
        
        Console.WriteLine();
    }
}

