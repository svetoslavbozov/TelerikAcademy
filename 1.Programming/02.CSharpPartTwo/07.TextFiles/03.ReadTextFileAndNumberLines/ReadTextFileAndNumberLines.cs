/*Write a program that reads a text file and inserts line numbers in front of each of its lines. The result should be written to another text file.
*/

using System;
using System.IO;

class ReadTextFileAndNumberLines
{
    static void Main(string[] args)
    {
        Console.WriteLine(" Enter sourse file path");
        string sourse = Console.ReadLine();

        Console.WriteLine("Enter destination file path");

        string destination = Console.ReadLine();

        
        using (StreamReader readFile = new StreamReader("../../ReadTextFileAndNumberLines.cs"))
        {
            using (StreamWriter writeFile = new StreamWriter("../../text.txt"))
            {
                string line = readFile.ReadLine();
                int number = 1;

                while (line != null)
                {
                    writeFile.WriteLine("{0}. {1}", number++, line);
                    line = readFile.ReadLine();
                }
            }
        }
    }
}
