using System;

class CalculateCirclesAreaAndPerimeter
{
    static void Main()
    {
        Console.WriteLine("Enter radius");
        double radius = double.Parse(Console.ReadLine());

        Console.WriteLine("A = " + CalculateArea(radius));
        Console.WriteLine("C = " + CalculatePerimeter(radius));

    }
    static double CalculateArea(double radius)
    {
        return Math.PI * radius * radius;
    }

    static double CalculatePerimeter(double radius)
    {
        return 2 * Math.PI * radius;
    }
}

