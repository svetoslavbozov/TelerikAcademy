/*Write a program that reads three integer numbers N, K and S and an array of N elements from the console. Find in the array a subset of K elements that have sum S or indicate about its absence.*/

using System;

class FindSubsetInGivenArray
{
    static void Main()
    {
        Console.WriteLine("Enter array lenght:");
        int arrayLenght = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter subarray lenght:");
        int subArrayLenght = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter searched summary:");
        int searchedSum = int.Parse(Console.ReadLine());        

        Console.WriteLine("Enter array members");
        int[] intArray = new int[arrayLenght];

        for (int index = 0; index < arrayLenght; index++)
        {
            intArray[index] = int.Parse(Console.ReadLine());
        }

        int bestSubsetIndex = SearchSubsetSum(arrayLenght, subArrayLenght, searchedSum, intArray);

        if (bestSubsetIndex == -1)
        {
            Console.WriteLine("Not Found");
        }
        else
        {
            PrintResult(intArray, bestSubsetIndex);
        }
    }

    private static int SearchSubsetSum(int arrayLenght, int subArrayLenght, int searchedSum, int[] intArray)
    {
        int subsetsCount = (int)Math.Pow(2, arrayLenght) - 1;
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
            if (currentSum == searchedSum && elementsAdded == subArrayLenght)
            {
                bestSubsetIndex = subsetIndex;
                break;
            }
        }
        return bestSubsetIndex;
    }
    private static void PrintResult(int[] array, int bestSubsetIndex)
    {
        Console.Write("Yes (");
        for (int index = 1; index <= array.Length; index++)
        {
            if (((bestSubsetIndex >> (index - 1)) & 1) == 1)
            {
                Console.Write(array[index - 1]);

                if (index != array.Length - 1)
                {
                    Console.Write("+");
                }
            }
        }
        Console.WriteLine(" \b)");
    }
}

