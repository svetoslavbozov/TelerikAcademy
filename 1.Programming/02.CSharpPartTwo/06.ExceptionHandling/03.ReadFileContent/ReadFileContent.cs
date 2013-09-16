﻿/*Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…). Be sure to catch all possible exceptions and print user-friendly error messages.
*/

using System;
using System.IO;
using System.Security;

class ReadFileContent
{
    static void Main()
    {
        Console.Write("Enter the full path of the file you want to read: ");
        ReadFile(Console.ReadLine());
    }

    static void ReadFile(string filePath)
    {
        using (StreamReader sr = new StreamReader(filePath))
        {
            try
            {
                while (sr.Peek() >= 0)
                {
                    Console.WriteLine(sr.ReadLine());
                }
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The file path contains a directory that cannot be found!");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file '{0}' was not found!", filePath);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("No file path is given!");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The entered file path is not correct!");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("The entered file path is too long - 248 characters are the maximum!");
            }
            catch (UnauthorizedAccessException uoae)
            {
                Console.WriteLine(uoae.Message);
            }
            catch (SecurityException)
            {
                Console.WriteLine("You don't have the required permission to access this file!");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("Invalid file path format!");
            }
            catch (IOException ioe)
            {
                Console.WriteLine(ioe.Message);
            }
            finally
            {
                Console.WriteLine("Good Bye");
            }
        }
    }    
}

