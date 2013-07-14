using System;

class Garden
{
    static void Main()
    {
        int tomatoSeeds = int.Parse(Console.ReadLine());
        int tomatoArea = int.Parse(Console.ReadLine());

        int cucumberSeeds = int.Parse(Console.ReadLine());
        int cucumberArea = int.Parse(Console.ReadLine());

        int potatoSeeds = int.Parse(Console.ReadLine());
        int potatoArea = int.Parse(Console.ReadLine());

        int carrotSeeds = int.Parse(Console.ReadLine());
        int carrotArea = int.Parse(Console.ReadLine());

        int cabbageSeeds = int.Parse(Console.ReadLine());
        int cabbageArea = int.Parse(Console.ReadLine());

        int beansSeeds = int.Parse(Console.ReadLine());

        double totalCost = tomatoSeeds * 0.5;
        totalCost += cucumberSeeds * 0.4;
        totalCost += potatoSeeds * 0.25;
        totalCost += carrotSeeds * 0.6;
        totalCost += cabbageSeeds * 0.3;
        totalCost += beansSeeds * 0.4;

        int totalArea = tomatoArea + cucumberArea + potatoArea + carrotArea + cabbageArea;

        Console.WriteLine("Total costs: {0:f2}", totalCost);

        if (totalArea == 250)
        {
            Console.WriteLine("No area for beans");
        }
        else if (totalArea > 250)
        {
            Console.WriteLine("Insufficient area");
        }
        else
        {
            Console.WriteLine("Beans area: {0}", 250 - totalArea);
        }
    }
}

