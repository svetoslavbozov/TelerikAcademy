using System;

class CheckIfPointIsInCircle
{
    static void Main()
    {
        Console.WriteLine("Enter coordinate X: ");
        int coordinateX = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter coordinate Y: ");
        int coordinateY = int.Parse(Console.ReadLine());

        Console.WriteLine("The point " + ((coordinateX*coordinateX + coordinateY*coordinateY < 25) ? "is " : "is not ") + "in circle K(0,5)");
    }
}

