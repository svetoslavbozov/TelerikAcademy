/*Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file. Ensure it will work with large files (e.g. 100 MB).
*/

using System;
using System.IO;
using System.Text.RegularExpressions;

class MatchAndReplaceSubstring
{
    static void Main()
    {
        Console.WriteLine("Enter file path");
        string filePath = Console.ReadLine();
        var fileContents = Regex.Replace(File.ReadAllText(filePath),"start", "finish", RegexOptions.IgnoreCase);
        File.WriteAllText(filePath, fileContents);
    }
}
