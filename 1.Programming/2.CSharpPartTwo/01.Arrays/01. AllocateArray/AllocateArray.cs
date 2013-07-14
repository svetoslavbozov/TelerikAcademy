/*Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5. Print the obtained array on the console.*/

using System;

class AllocateArray
{
    static void Main()
    {
        int arrayLenght = 20;
        int[] array = new int[arrayLenght];

        for (int index = 0; index < arrayLenght; index++)
        {
            array[index] = index * 5;
        }

        for (int index = 0; index < arrayLenght; index++)
        {
            Console.Write("{0}", array[index]);

            if (index != arrayLenght - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}

