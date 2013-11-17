using System;
public class Circle : Shape
{
    public Circle(int radius)
        : base(radius, height: radius)
    {
    }

    public override double CalculateSurface()
    {
        return Math.PI * (this.Width * this.Width);
    }
}

