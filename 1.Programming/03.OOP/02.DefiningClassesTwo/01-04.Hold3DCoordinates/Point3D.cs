using System;
using System.Text;

public struct Point3D
{
    private int x;
    private int y;
    private int z;

    private static readonly Point3D zeroPoint = new Point3D(0, 0, 0);

    public Point3D(int x, int y, int z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }


    public static Point3D ZeroPoint
    {
        get { return zeroPoint; }
    }
    

    public int Z
    {
        get { return z; }
        set { z = value; }
    }
    

    public int Y
    {
        get { return y; }
        set { y = value; }
    }
    

    public int X
    {
        get { return x; }
        set { x = value; }
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();

        result.AppendLine("Coordinate X = " + this.x);
        result.AppendLine("Coordinate Y = " + this.y);
        result.AppendLine("Coordinate Z = " + this.z);

        return result.ToString();
    }
}

