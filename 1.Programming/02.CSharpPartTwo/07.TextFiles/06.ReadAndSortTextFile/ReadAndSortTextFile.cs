/*Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file. Example:
	Ivan			George
	Peter			Ivan
	Maria			Maria
	George			Peter

 */

using System;
using System.IO;
using System.Linq;

class ReadAndSortTextFile
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter file path");
        string filePath = Console.ReadLine();

        SortTextFile(filePath);
    }
    static  void SortTextFile(string filePath)
    {
        using (StreamReader textFile = new StreamReader(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);

            Array.Sort(lines);

            using (StreamWriter write = new StreamWriter(@"C:\Users\admin-pc\Desktop\3.txt")) //change destination
            {
                foreach (var line in lines)
                {
                    write.WriteLine(line);
                }                
            }
        }
    }
}

