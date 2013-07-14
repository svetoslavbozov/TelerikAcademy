using System;

class ShipDamage
{
    static void Main()
    {
        int SX1 = int.Parse(Console.ReadLine());
        int SY1 = int.Parse(Console.ReadLine());
        int SX2 = int.Parse(Console.ReadLine());
        int SY2 = int.Parse(Console.ReadLine());
        int H = int.Parse(Console.ReadLine());
        int CX1 = int.Parse(Console.ReadLine());
        int CY1 = int.Parse(Console.ReadLine());
        int CX2 = int.Parse(Console.ReadLine());
        int CY2 = int.Parse(Console.ReadLine());
        int CX3 = int.Parse(Console.ReadLine());
        int CY3 = int.Parse(Console.ReadLine());

        int[] CY = new int[3];
        CY[0] = 2 * H - CY1;
        CY[1] = 2 * H - CY2;
        CY[2] = 2 * H - CY3;

        int[] CX = new int[3];
        CX[0] = CX1;
        CX[1] = CX2;
        CX[2] = CX3;

        int minX = Math.Min(SX1, SX2);
        int maxX = Math.Max(SX1, SX2);
        int minY = Math.Min(SY1, SY2);
        int maxY = Math.Max(SY1, SY2);

        int damage = 0;

        for (int i = 0; i < 3; i++)
        {
            if ((CX[i] > minX && CX[i] < maxX) && (CY[i] < maxY && CY[i] > minY))
            {
                damage += 100;
            }
            if ((CX[i] > minX && CX[i] < maxX) && (CY[i] == SY1 || CY[i] == SY2))
            {
                damage += 50;
            }
            if ((CX[i] == SX1 || CX[i] == SX2) && (CY[i] < maxY && CY[i] > minY))
            {
                damage += 50;
            }
            if ((CX[i] == SX1 || CX[i] == SX2) && (CY[i] == SY1 || CY[i] == SY2))
            {
                damage += 25;
            }
        }
        Console.WriteLine("{0}%", damage);

    }
}

