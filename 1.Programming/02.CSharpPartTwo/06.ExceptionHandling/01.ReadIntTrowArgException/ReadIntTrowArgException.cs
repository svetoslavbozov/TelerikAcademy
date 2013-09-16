/*Write a program that reads an integer number and calculates and prints its square root. If the number is invalid or negative, print "Invalid number". In all cases finally print "Good bye". Use try-catch-finally.
*/

using System;

class ReadIntTrowArgException
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter integer number:");       

        try
        {
            uint number = uint.Parse(Console.ReadLine());
            Console.WriteLine("The square root of your number is: {0}", Math.Sqrt(number));
        }
        catch(OverflowException oe)
        {
            Console.Error.WriteLine("Error: " + oe.Message);
        }
        catch(FormatException fe)
        {
            Console.Error.WriteLine("Invalid Number");
            throw fe;
        }
        finally
        {
            Console.WriteLine("Good Bye");
        }
    }
}

