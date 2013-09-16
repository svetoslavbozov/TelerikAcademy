﻿/*Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”). Write a program to test this method.
*/

using System;

class SayHello
{
    static void Main()
    {
        Console.WriteLine("Enter your name");
        string name = Console.ReadLine();

        PrintHello(name);
    }
    static void PrintHello(string name)
    {
        Console.WriteLine("Hello {0}", name);
    }
}

