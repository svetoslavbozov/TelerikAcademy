/*Write a program that deletes from a text file all words that start with the prefix "test". Words contain only the symbols 0...9, a...z, A…Z, _.
 */

using System;
using System.IO;
using System.Text.RegularExpressions;
class DeleteWordsFromTextFile
{
    static void Main()
    {
        Console.WriteLine("Enter file path");
        string filePath = Console.ReadLine();

        var fileContents = Regex.Replace(File.ReadAllText(filePath), @"\btest[a-zA-z_]+", "", RegexOptions.IgnoreCase);

        File.WriteAllText(filePath, fileContents);
    }
}

