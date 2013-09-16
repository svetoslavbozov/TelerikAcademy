/** Write a program that calculates the value of given arithmetical expression. The expression can contain the following elements only:
Real numbers, e.g. 5, 18.33, 3.14159, 12.6
Arithmetic operators: +, -, *, / (standard priorities)
Mathematical functions: ln(x), sqrt(x), pow(x,y)
Brackets (for changing the default priorities)
	Examples:
	(3+5.3) * 2.7 - ln(22) / pow(2.2, -1.7)  ~ 10.6
	pow(2, 3.14) * (3 - (3 * sqrt(2) - 3.2) + 1.5*0.3)  ~ 21.22
	Hint: Use the classical "shunting yard" algorithm and "reverse Polish notation".
 
    http://en.wikipedia.org/wiki/Shunting-yard_algorithm
    http://en.wikipedia.org/wiki/Reverse_Polish_notation
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Threading;

class CalculateExpression
{
    static Dictionary<string,int> operatorsPriority= new Dictionary<string, int>() 
    {
        { "sqrt", 4 }, { "ln", 4 }, { "^", 4 }, { "*", 3 }, { "/", 3 }, { "+", 2 }, { "-", 2 }, { "(", 0 }
    };
    static Stack<string> operators = new Stack<string>();
    static Queue<string> ReversedPolishNotation = new Queue<string>();
    static Stack<double> result = new Stack<double>();

    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Enter expression with spaces between every digit and operators exept for negative numbers ( example: ( 3 + 5.3 ) * 2.7 - ln ( 22 ) / ( 2.2 ^ -1.7 ) ) :");

        Console.WriteLine();

        //read expression
        string[] expression = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

        // convert from infix expression to postfix (example "( 1 + 2 ) -> 12+ "
        for (int index = 0; index < expression.Length; index++)
        {
            if (IsDigit(expression[index]))
            {
                ReversedPolishNotation.Enqueue(expression[index]);
            }
            else
            {
                if (expression[index] == "(")
                {
                    operators.Push(expression[index]);
                }
                else if (expression[index] == ")")
                {
                    while (operators.Peek() != "(")
                    {
                        ReversedPolishNotation.Enqueue(operators.Pop());
                    }

                    operators.Pop();
                }
                else if (operators.Count() > 0 && !IsHigherPriority(expression[index]))
                {
                    while (operators.Count() > 0 && !IsHigherPriority(expression[index]))
                    {
                        ReversedPolishNotation.Enqueue(operators.Pop());
                    }

                    operators.Push(expression[index]);
                }
                else
                {
                    operators.Push(expression[index]);
                }
            }
        }

        while (operators.Count() > 0)
        {
            ReversedPolishNotation.Enqueue(operators.Pop());
        }

        //print result
        Console.WriteLine("Result: " + Evaluate());
    }

    //check if digit
    static bool IsDigit (string symbol)
    {
        double result;
        return double.TryParse(symbol,out result);
    }

    //check operators priority
    static bool IsHigherPriority(string symbol)
    {
        return (operatorsPriority[operators.Peek()] < operatorsPriority[symbol]) || ((operatorsPriority[operators.Peek()] == 4) && (operatorsPriority[symbol] == 4));        
    } 

    //calculate the final RPN expression
    static double Evaluate()
    {
        var result = new Stack<double>();

        foreach (var token in ReversedPolishNotation)

            if (token == "+") result.Push(result.Pop() + result.Pop());
            else if (token == "-") result.Push(-result.Pop() + result.Pop());
            else if (token == "*") result.Push(result.Pop() * result.Pop());
            else if (token == "/") result.Push(1 / result.Pop() * result.Pop()); // (1 / result.pop) is the divisor
            else if (token == "ln") result.Push(Math.Log(result.Pop(), Math.E));
            else if (token == "sqrt") result.Push(Math.Sqrt(result.Pop()));
            else if (token == "^") result.Push(Math.Pow(y: result.Pop(), x: result.Pop())); // x ^ y
            else result.Push(double.Parse(token));

        return result.Pop();
    }
}

