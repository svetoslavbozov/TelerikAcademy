﻿using System;

class ApplyBonusPointsToGivenScore
{
    static void Main()
    {
        Console.WriteLine("Enter score: ");
        int points = int.Parse(Console.ReadLine());

        switch (points)
        {
            case 1:
            case 2:
            case 3:
                points *= 10;
                Console.WriteLine(points);
                break;
            case 4:
            case 5:
            case 6:
                points *= 100;
                Console.WriteLine(points);
                break;
            case 7:
            case 8:
            case 9:
                points *= 1000;
                Console.WriteLine(points);
                break;

            default:
                Console.WriteLine("Invalid input");
                break;
        }
        
    }
}

