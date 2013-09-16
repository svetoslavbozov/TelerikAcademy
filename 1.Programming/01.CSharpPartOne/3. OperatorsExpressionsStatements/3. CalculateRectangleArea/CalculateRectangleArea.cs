using System;

class CalculateRectangleArea
{
    static void Main()
    {
        Console.WriteLine("Enter side A:");
        int sideA = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter side B:");
        int sideB = int.Parse(Console.ReadLine());

        Console.WriteLine("Rectangle area equals " + sideA * sideB + " (whatever units you used)");
    }
}

