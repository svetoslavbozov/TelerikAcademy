using System;
using System.Collections.Generic;

class SolveQuadraticEquasion
{
    static void Main()
    {
        Console.WriteLine("Enter a:");
        int coefficientA = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter b:");
        int coefficientB = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter c:");
        int coefficientC = int.Parse(Console.ReadLine());


        double discriminant = (Math.Pow(coefficientB, 2) - 4 * coefficientA * coefficientC);

        if (discriminant == 0)
        {
            float x = -coefficientB / (2 * coefficientA);
            Console.WriteLine(x);
        }
        else if (discriminant > 0)
        {
            double x1 = (-coefficientB + Math.Sqrt(discriminant)) / (2 * coefficientA);
            double x2 = (-coefficientB - Math.Sqrt(discriminant)) / (2 * coefficientA);

            Console.WriteLine(x1);
            Console.WriteLine(x2);
        }
        else if (discriminant < 0)
        {
            Console.WriteLine("No solution");
        }
    }
}

