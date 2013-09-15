/*Write a method that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).
*/
using System;
using System.Linq;

class CompareArrayElements
{
    static void Main()
    {
        Console.WriteLine("Enter array elements separated by comma:");
        int[] array = Console.ReadLine().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(x => Convert.ToInt32(x)).ToArray();

        Console.WriteLine("Enter index:");
        int index = int.Parse(Console.ReadLine());

        CompareNeighboringElements(array, index);
    }
    static void CompareNeighboringElements(int[] array, int index)
    {
        if (!IsInRange(array,index))
        {
            Console.WriteLine("Out of Range");
            return;
        }
        for (int i = index - 1; i <= index + 1; i += 2)
        {
            if (IsInRange(array, i))
            {
                Console.WriteLine("Element {0} is " + (array[i] > array[index] ? "bigger" : "smaller") + " than selected element", array[i]);
            }
        }        
    }
    static bool IsInRange(int[] array, int index)
    {
        return index >= 0 && index < array.Length;
    }
}

