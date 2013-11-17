using System;

public static class DistanceIn3D
{
    public static double CalculateDistanceIn3D(Point3D firstPoint, Point3D secondPoint)
    {
        double result = 0;
        return result = Math.Sqrt((firstPoint.X - secondPoint.X) * (firstPoint.X - secondPoint.X) + (firstPoint.Y - secondPoint.Y) * (firstPoint.Y - secondPoint.Y) + (firstPoint.Z - secondPoint.Z) * (firstPoint.Z - secondPoint.Z));
    }
}

