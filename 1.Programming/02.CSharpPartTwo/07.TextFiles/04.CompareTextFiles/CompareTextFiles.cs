/*Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different. Assume the files have equal number of lines.
*/

using System;
using System.IO;

class CompareTextFiles
{
    static void Main()
    {
        Console.WriteLine("First file path");
        string first = Console.ReadLine();

        Console.WriteLine("Second file path");
        string second = Console.ReadLine();

        CompareFiles(first,second);
    }

    static void CompareFiles(string first, string second)
    {
        int equalLines = 0;
        int differentLines = 0;

        using (StreamReader firstFile = new StreamReader(first))
        {
            using (StreamReader secondFile = new StreamReader(second))
            {
                string line1 = firstFile.ReadLine();
                string line2 = secondFile.ReadLine();

                while (line1 !=  null)
                {
                    if (line1 == line2)
                    {
                        equalLines++;
                    }
                    else
                    {
                        differentLines++ ;
                    }

                    line1 = firstFile.ReadLine();
                    line2 = secondFile.ReadLine();
                }
            }
        }

        Console.WriteLine("Equal = " + equalLines);
        Console.WriteLine("Different = " + differentLines);
    }
}

