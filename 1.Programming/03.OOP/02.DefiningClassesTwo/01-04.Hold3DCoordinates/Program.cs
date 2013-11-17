/*
    1.Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space. Implement the ToString() to enable printing a 3D point.
    2.Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}. Add a static property to return the point O.
    3. Write a static class with a static method to calculate the distance between two points in the 3D space.
    4.Create a class Path to hold a sequence of points in the 3D space. Create a static class PathStorage with static methods to save and load paths from a text file. Use a file format of your choice.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_04.Hold3DCoordinates
{
    class Program
    {
        static void Main(string[] args)
        {
            Point3D point = new Point3D();

            point.X = 1;
            point.Y = 1;
            point.Z = 1;

            Console.WriteLine(point.ToString());

            Point3D zeroPoint = Point3D.ZeroPoint;

            Console.WriteLine(zeroPoint);

            Console.WriteLine(DistanceIn3D.CalculateDistanceIn3D(point,zeroPoint));

            List<Point3D> path3DToSave = new List<Point3D>();
            path3DToSave.Add(Point3D.ZeroPoint);
            path3DToSave.Add(point);

            PathStorage.SavePath(path3DToSave);

            List<Point3D> path3DToLoad = new List<Point3D>();
            path3DToLoad = PathStorage.LoadPath("pathStorage.txt");

            Console.WriteLine();
        }
    }
}
