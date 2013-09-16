/*Write a program that reads a text file and prints on the console its odd lines.
*/

using System;
using System.IO;

class ReadTextFileOddLines
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the full path of the file: ");
        ReadFile(Console.ReadLine());
    }
    static void ReadFile(string filePath)
    {
        using (StreamReader readFile = new StreamReader(filePath))
        {
            int counter = 0;

            while (readFile.Peek() >= 0)
            {
                string line = readFile.ReadLine();

                if (counter % 2 != 0)
                {
                    Console.WriteLine(line);                    
                }

                counter++;
            }
        }
    }
}

