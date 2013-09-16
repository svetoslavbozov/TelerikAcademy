/*07.Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file. Ensure it will work with large files (e.g. 100 MB).
  08.Modify the solution of the previous problem to replace only whole words (not substrings).
 * */


using System;
using System.IO;
using System.Text.RegularExpressions;

class MatchAndReplaceSubstring
{
    static void Main()
    {
        Console.WriteLine("Enter file path");
        string filePath = Console.ReadLine();
        var fileContents = Regex.Replace(File.ReadAllText(filePath), @"\bstart\b", "finish", RegexOptions.IgnoreCase);
        File.WriteAllText(filePath, fileContents);
    }
}
