using System;

public abstract class Shape
{
    private int width;
    private int height;

    public int Height
    {
        get { return height; }
        set 
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("Heigth must be bigger than 0");
            }

            height = value; 
        }
    }

    public int Width
    {
        get { return width; }
        set 
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("Width must be bigger than 0");
            }

            width = value; }
    }
    public Shape(int width, int height)
    {
        this.Width = width;
        this.Height = height;
    }
    public abstract double CalculateSurface();
}

