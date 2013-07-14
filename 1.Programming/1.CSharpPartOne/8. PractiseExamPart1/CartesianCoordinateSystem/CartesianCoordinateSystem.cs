using System;

class CartesianCoordinateSystem
{
    static void Main()
    {
        double coodrinateX = double.Parse(Console.ReadLine());
        double coodrinateY = double.Parse(Console.ReadLine());

        bool[] results = new bool[7];

        results[0] = (coodrinateX == 0 && coodrinateY == 0);
        results[1] = (coodrinateX > 0 && coodrinateY > 0);
        results[2] = (coodrinateX < 0 && coodrinateY > 0);
        results[3] = (coodrinateX < 0 && coodrinateY < 0);
        results[4] = (coodrinateX > 0 && coodrinateY < 0);
        results[5] = (coodrinateX == 0 && (coodrinateY > 0 || coodrinateY < 0));
        results[6] = ((coodrinateX > 0 || coodrinateX < 0) && coodrinateY == 0);

        for (int i = 0; i < 7; i++)
        {
            if (results[i])
            {
                Console.WriteLine(i);
            }
        }
    }
}

