/* Write a program that can solve these tasks:
    -Reverses the digits of a number
    -Calculates the average of a sequence of integers
    -Solves a linear equation a * x + b = 0
Create appropriate methods.
Provide a simple text-based menu for the user to choose which task to solve.
Validate the input data:
    -The decimal number should be non-negative
    -The sequence should not be empty
    -a should not be equal to 0
 */

using System;
using System.Linq;
using System.Text;
class SolveCalculateReverse
{
    static void Main()
    {
        Console.WriteLine("Select action:");
        Console.WriteLine("1 - Reverse digits");
        Console.WriteLine("2 - Calculate the average of a sequence");
        Console.WriteLine("3 - Solve linear equasion");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                ReadReverseDigitsInput();
                break;
            case 2:
                ReadAverageInput();
                break;
            case 3:
                ReadEquasionInput();
                break;
            default:
                break;
        }
    }
    static void ReadReverseDigitsInput()
    {
        Console.WriteLine("Enter your non-negative number: ");

        decimal number = decimal.Parse(Console.ReadLine());

        if (number < 0)
        {
            throw new ArgumentException("I said non-negative !!!");
        }
        else
        {
            PrintReversedDigits(number);
        }
    }
    static void PrintReversedDigits(decimal number)
    {
        StringBuilder result = new StringBuilder();

        char[] digits = number.ToString().Replace(".","").ToCharArray();

        Array.Reverse(digits);

        result.Append(digits);

        Console.WriteLine(Convert.ToDecimal(result.ToString()));        
    }
    static void ReadAverageInput()
    {
        Console.WriteLine("Enter non-empty sequence of elements separated by comma: ");

        int[] sequence = Console.ReadLine().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(x => Convert.ToInt32(x)).ToArray();
    
        if (sequence.Length == 0)
        {
            throw new ArgumentException("I said non-empty !!!");
        }
        else
        {
            PrintAverage(sequence);
        }
    }

    static void PrintAverage(int[] sequence)
    {
        int result = 0;

        for (int i = 0; i < sequence.Length; i++)
        {
            result += sequence[i];
        }

        Console.WriteLine(result/sequence.Length);
    }

    static void ReadEquasionInput()
    {
        Console.WriteLine("Enter coefficients such as a is not equal to 0:");

        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());

        if (a == 0)
        {
            throw new ArgumentException("a should not be 0 !!!!!");
        }

        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine((double)-b/a);
    }
}

