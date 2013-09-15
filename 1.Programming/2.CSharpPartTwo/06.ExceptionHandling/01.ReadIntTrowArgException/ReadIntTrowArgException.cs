/*Write a program that reads an integer number and calculates and prints its square root. If the number is invalid or negative, print "Invalid number". In all cases finally print "Good bye". Use try-catch-finally.
*/

using System;

class ReadIntTrowArgException
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter integer number:");
        int number = int.Parse(Console.ReadLine());

        try
        {
            Console.WriteLine("The square root of your number is: {0}", Math.Sqrt(number));
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine("Invalid Number");
            throw ae;
        }
        catch (StackOverflowException oe)
        {
            Console.WriteLine("Invalid Number");
            throw oe;
        }
        finally
        {
            Console.WriteLine("Good Bye");
        }
    }
}

