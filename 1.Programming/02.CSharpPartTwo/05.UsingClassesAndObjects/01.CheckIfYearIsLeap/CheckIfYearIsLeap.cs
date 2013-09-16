/*1.Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.
*/
using System;
class CheckIfYearIsLeap
{
    static void Main()
    {
        Console.Write("Enter year to check: ");
        Console.WriteLine("This is " + (DateTime.IsLeapYear(int.Parse(Console.ReadLine())) ? "" : "not ") + "a leap year");
    }
}

