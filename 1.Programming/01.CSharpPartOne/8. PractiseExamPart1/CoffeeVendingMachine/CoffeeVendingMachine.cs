using System;

class CoffeeVendingMachine
{
    static void Main()
    {
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int n3 = int.Parse(Console.ReadLine());
        int n4 = int.Parse(Console.ReadLine());
        int n5 = int.Parse(Console.ReadLine());

        double machineTray = n1 * 0.05 + n2 * 0.1 + n3 * 0.2 + n4 * 0.5 + n5;

        float amount = float.Parse(Console.ReadLine());
        float price = float.Parse(Console.ReadLine());

        if (amount < price)
        {
            Console.WriteLine("More {0:F2}", price - amount);
        }
        else
        {
            if (machineTray < amount - price)
            {
                Console.WriteLine("No {0:F2}", (amount - price) - machineTray);
            }
            else if (machineTray >= amount - price)
            {
                Console.WriteLine("Yes {0:F2}", machineTray - (amount - price));
            }
        }
    }
}

