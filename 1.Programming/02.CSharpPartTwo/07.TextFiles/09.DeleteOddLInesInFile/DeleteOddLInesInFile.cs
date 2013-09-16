/*Write a program that deletes from given text file all odd lines. The result should be in the same file.
 * */

using System;
using System.IO;

class DeleteOddLInesInFile
{
    static void Main()
    {
        Console.WriteLine("Enter File path");
        string filePath = Console.ReadLine();
        DeleteOddLines(filePath);
    }
    static void DeleteOddLines(string filePath)
    {
        string[] allLines = File.ReadAllLines(filePath);

        for (int i = 0; i < allLines.Length; i++)
        {
            if (i%2 == 0)
            {
                allLines[i] = null;
            }
        }

        File.WriteAllLines(filePath, allLines);
    }
}
