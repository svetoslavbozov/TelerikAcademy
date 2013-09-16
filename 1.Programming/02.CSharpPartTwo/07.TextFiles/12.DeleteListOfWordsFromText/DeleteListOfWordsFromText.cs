/*Write a program that removes from a text file all words listed in given another text file. Handle all possible exceptions in your methods.
*/

using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Security;
class DeleteListOfWordsFromText
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
                       
            string[] word = File.ReadAllText(wordListPath).Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
               
            foreach (var item in word)
            {
                {
                    text = Regex.Replace(text, @"\s\b" + item + @"\b", String.Empty);
	            }                        
            }

            File.WriteAllText(textPath, text);
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

