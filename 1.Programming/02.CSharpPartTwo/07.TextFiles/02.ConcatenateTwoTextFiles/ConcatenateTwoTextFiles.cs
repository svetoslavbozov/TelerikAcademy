/*Write a program that concatenates two text files into another text file.*/

using System;
using System.IO;

class ConcatenateTwoTextFiles
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the full path of the first file: ");
        string fileOne = Console.ReadLine();
        Console.WriteLine("Enter the full path of the second file: ");
        string fileTwo = Console.ReadLine();

        WriteFile(fileOne, fileTwo);
    }
    static void WriteFile(string filePathOne, string filePathTwo)
    {
        using(StreamReader first = new StreamReader(filePathOne))
	    {
            using (StreamReader second = new StreamReader(filePathTwo))
            {
                File.WriteAllText(@"C:\Users\admin-pc\Desktop\blabla.txt", first.ReadToEnd());
                File.AppendAllText(@"C:\Users\admin-pc\Desktop\blabla.txt", second.ReadToEnd());
            }
	    }
    }
}

        
    


