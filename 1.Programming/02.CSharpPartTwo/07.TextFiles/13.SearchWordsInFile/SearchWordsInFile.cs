/*Write a program that reads a list of words from a file words.txt and finds how many times each of the words is contained in another file test.txt. The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order. Handle all possible exceptions in your methods.
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;
using System.Security;

class SearchWordsInFile
{
    static void Main()
    {
        Console.WriteLine("enter text file path");
        string textPath = Console.ReadLine();

        Console.WriteLine("enter list of words file path");
        string wordListPath = Console.ReadLine();
        
        try
        {
            string text = File.ReadAllText(textPath);

            string[] words = File.ReadAllText(wordListPath).Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            List<Tuple<string, int>> result = new List<Tuple<string, int>>();

            foreach (var item in words)
            {
                result.Add(new Tuple<string,int>(Regex.Match(text,item).Groups[0].Value, Regex.Matches(text, item).Count));
            }

            result = result.OrderByDescending(x => x.Item2).ToList();

            using (StreamWriter writeResult = new StreamWriter("../../result.txt"))
            {
                foreach (var word in result)
                {
                    writeResult.WriteLine(word.Item2 + "  -  " + word.Item1);
                }
            }
        }

        catch (FileNotFoundException fe)
        {
            Console.WriteLine(fe.Message);
        }

        catch (DirectoryNotFoundException dnf)
        {
            Console.WriteLine(dnf.Message);
        }

        catch (IOException ioe)
        {
            Console.WriteLine(ioe.Message);
        }

        catch (SecurityException se)
        {
            Console.WriteLine(se.Message);
        }

        catch (UnauthorizedAccessException uae)
        {
            Console.WriteLine(uae.Message);
        }
    }
}

