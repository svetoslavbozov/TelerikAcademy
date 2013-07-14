using System;
using System.Globalization;
using System.Threading;

class MathExpression
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        double N = double.Parse(Console.ReadLine());
        double M = double.Parse(Console.ReadLine());
        double P = double.Parse(Console.ReadLine());
        
        double numerator = N * N + 1 / (M * P) + 1337;
        double divisor = N - 128.523123123 * P;
        double sin = Math.Sin((int)M % 180);
        double result = (numerator / divisor) + sin;

        Console.WriteLine("{0:F6}", result);
    }
}

