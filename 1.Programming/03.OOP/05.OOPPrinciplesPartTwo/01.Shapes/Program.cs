using System;
class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle(5);
        Triangle triangle = new Triangle(3, 5);
        Rectangle rectangle = new Rectangle(2, 4);

        Shape[] differentShapes = { circle, triangle, rectangle };

        foreach (Shape item in differentShapes)
        {
            Console.WriteLine("Figure = {0} surface = {1:F2}",
            item.GetType().Name.PadRight(9, ' '),
            item.CalculateSurface());
        }
    }
}
