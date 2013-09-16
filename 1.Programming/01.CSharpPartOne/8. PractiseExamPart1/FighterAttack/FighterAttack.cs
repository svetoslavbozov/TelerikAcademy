using System;

class FighterAttack
{
    static void Main()
    {
        int PX1 = int.Parse(Console.ReadLine());
        int PY1 = int.Parse(Console.ReadLine());
        int PX2 = int.Parse(Console.ReadLine());
        int PY2 = int.Parse(Console.ReadLine());        
        int FX = int.Parse(Console.ReadLine());
        int FY = int.Parse(Console.ReadLine());
        int D = int.Parse(Console.ReadLine());

        int minX = Math.Min(PX1, PX2);
        int maxX = Math.Max(PX1, PX2);
        int minY = Math.Min(PY1, PY2);
        int maxY = Math.Max(PY1, PY2);

        int hitPointX = FX + D;
        int hitPointY = FY;

        int damage = 0;

        if ((hitPointX >= minX && hitPointX <= maxX) && ( hitPointY >= minY && hitPointY <= maxY)) //direct hit
        {
            damage += 100;
        }
        if ((hitPointX + 1 >= minX && hitPointX + 1 <= maxX) && ( hitPointY >= minY && hitPointY <= maxY)) //front hit
        {
            damage += 75;
        }
        if ((hitPointX >= minX && hitPointX <= maxX) && ( hitPointY + 1 >= minY && hitPointY + 1 <= maxY)) // upper hit
        {
            damage += 50;
        }
        if ((hitPointX >= minX && hitPointX <= maxX) && ( hitPointY - 1 >= minY && hitPointY - 1 <= maxY)) // lower hit
        {
            damage += 50;
        }

        Console.WriteLine("{0}%", damage);
    }
}

