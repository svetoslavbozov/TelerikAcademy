using System;
using System.Linq;

class FIndGivenSumInArray
{
    static void Main()
    {
        Console.WriteLine("Enter array elements separated by comma:");
        int[] intArray = Console.ReadLine().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(x => Convert.ToInt32(x)).ToArray();

        Console.WriteLine("Enter the searched summary");
        int sum = int.Parse(Console.ReadLine());

        int currentSum = 0;
        int startIndex = 0;
        int endIndex = 0;

        for (int i = 0; i < intArray.Length; i++)
        {
            currentSum += intArray[i];

            if (currentSum == sum)
            {
                endIndex = i;
                break;
            }
            if (currentSum > sum)
            {
                startIndex++;
                i = startIndex - 1;
                currentSum = 0;
            }
        }

        for (int index = startIndex; index <= endIndex; index++)
        {
            Console.Write(intArray[index]);

            if (index != endIndex)
            {
                Console.Write(", ");
            }
        }

        Console.WriteLine();
    }
}



