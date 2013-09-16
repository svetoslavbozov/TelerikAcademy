/*Write methods that calculate the surface of a triangle by given:
Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.*/

using System;
class CalculateTriangleArea
{
    static void Main()
    {
        Console.WriteLine(CalculateByAltitude(1, 2));
        Console.WriteLine(CalculateBySides(3, 2, 4));
        Console.WriteLine(CalculateByAngle(1, 2, 30));
    }

    static double CalculateByAltitude(double a, double h)
    {
        return (a * h) / 2;
    }

    static double CalculateBySides(double a, double b, double c)
    {
        double p = (a + b + c) / 2;

        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }

    static double CalculateByAngle(double a, double b, double alpha)
    {
        return (a * b * Math.Sin(Math.PI * alpha / 180)) / 2;
    }
}       

