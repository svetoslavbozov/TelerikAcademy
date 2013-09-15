using System;

public class OneTaskIsNotEnough
{
    private static void Main()
    {
        int numberOfLamps = int.Parse(Console.ReadLine());
        Console.WriteLine(FindLastOpenedLamp(numberOfLamps));

        string commands = Console.ReadLine();
        Console.WriteLine(FindBoundedMoves(commands));

        string secondCommands = Console.ReadLine();
        Console.WriteLine(FindBoundedMoves(secondCommands));
    }
    private static int FindLastOpenedLamp(int numberOfLamps)
    {
        const int MaxLamps = 2000000;

        int lampsLeft = numberOfLamps;

        var lampsToTurnOn = new int[MaxLamps + 1];
        var lampsOff = new int[MaxLamps + 1];

        for (int i = 1; i <= lampsLeft; i++)
        {
            lampsOff[i] = i;
        }

        int step = 0; 
        while (lampsLeft > 1)
        {
            step++;

            int currentIndex = 1;
            while (currentIndex <= lampsLeft)
            {
                lampsToTurnOn[currentIndex] = step;
                currentIndex += step + 1;
            }

            int newCountOfLampsLeft = 0;
            for (int i = 1; i <= lampsLeft; i++)
            {
                if (lampsToTurnOn[i] != step)
                {
                    newCountOfLampsLeft++;
                    lampsOff[newCountOfLampsLeft] = lampsOff[i];
                }
            }

            lampsLeft = newCountOfLampsLeft;
        }

        return lampsOff[1];
    }

    private static string FindBoundedMoves(string commands)
    {
        int[] movesX = { 1, 0,-1, 0 };
        int[] movesY = { 0, 1, 0,-1 };

        int currentX = 0, currentY = 0, direction = 0;

        for (int i = 1; i <= 4; i++)
        {
            for (int j = 0; j < commands.Length; j++)
            {
                switch (commands[j])
                {
                    case 'S':
                        currentX += movesX[direction];
                        currentY += movesY[direction];
                        break;
                    case 'L':
                        direction = (direction + 3) % 4;
                        break;
                    case 'R':
                        direction = (direction + 1) % 4;
                        break;
                }
            }
        }

        if (currentX == 0 && currentY == 0)
        {
            return "bounded";
        }
        else
        {
            return "unbounded";
        }
    }
}
