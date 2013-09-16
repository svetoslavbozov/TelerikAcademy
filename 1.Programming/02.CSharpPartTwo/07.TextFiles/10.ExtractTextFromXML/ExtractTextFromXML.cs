/*Write a program that extracts from given XML file all the text without the tags. */

using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

class ExtractTextFromXML
{
    static void Main()
    {
        Console.WriteLine("enter fila path ");
        string filePath = Console.ReadLine();

        //string result = Regex.Replace(File.ReadAllText(filePath), @"<(.*?)>", "");
        //Console.WriteLine(result);

        ExtractText(filePath);
    }    

    static void ExtractText(string filePath)
    {
        StringBuilder result = new StringBuilder();

        using (StreamReader xmlFile = new StreamReader(filePath))
        {
            int currentChar;

            while ((currentChar = xmlFile.Read()) != -1)
            {
                if (currentChar == '>')
                {                    
                    while ((currentChar = xmlFile.Read()) != -1 && currentChar != '<')
                    {                                                 
                        result.Append((char)currentChar);                                               
                    }
                }

                if (result.ToString() != Environment.NewLine && result.ToString() != String.Empty)
                {                    
                    Console.WriteLine(result.ToString().Trim());
                }

                result.Clear();
            }
        }       
    }
}

