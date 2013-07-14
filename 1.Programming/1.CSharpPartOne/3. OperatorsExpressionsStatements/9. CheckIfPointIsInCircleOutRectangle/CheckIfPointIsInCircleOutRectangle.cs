using System;

class CheckIfPointIsInCircleOutRectangle
{
    static void Main()
    {
        Console.WriteLine("Enter coordinate X: ");
        int coordinateX = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter coordinate Y: ");
        int coordinateY = int.Parse(Console.ReadLine());

        bool isInCircle = ((coordinateX - 1) * (coordinateX - 1) + (coordinateY - 1) * (coordinateY - 1)) < 9;

        bool isOutRectangle = (coordinateX < -1 || coordinateX > 5) || (coordinateY > 1 || coordinateY < -1);

        Console.WriteLine("The point meets conditions ? " + (isInCircle && isOutRectangle));
    }
}

