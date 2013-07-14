using System;

class CalculateTrapezoidArea
{
    static void Main()
    {
        Console.WriteLine("Enter side A:");
        double sideA = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter side B:");
        double sideB = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter height:");
        double height = double.Parse(Console.ReadLine());

        Console.WriteLine(((sideA+sideB)*height)/2);
    }
}

