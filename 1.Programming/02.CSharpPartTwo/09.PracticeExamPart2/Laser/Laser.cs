using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Laser
{
    class Laser
    {
        static void Main(string[] args)
        {
            if (File.Exists("input.txt"))
            {
                Console.SetIn(new StreamReader("input.txt"));
            }

            int[] dimentions = ReadData(Console.ReadLine());
            int[] position = ReadData(Console.ReadLine());
            int[] direction = ReadData(Console.ReadLine());

            bool[,,] isVisited = new bool[width + 1, height + 1, dimentions[2] + 1];
            int[] nextPosition = new int[position.Length];

            while (true)
            {   
                isVisited[position[0], position[1], position[2]] = true;

                for (int i = 0; i < direction.Length; i++)
			    {
                    nextPosition[i] = position[i] + direction[i]; 
			    }

                if (isVisited[nextPosition[0], nextPosition[1], nextPosition[2]] || CheckIfEdgeOrCornerIsReached(nextPosition,dimentions) >=2)
                {
                    Console.WriteLine("{0} {1} {2}", position[0], position[1], position[2]);
                    return;
                }
                else if (CheckIfEdgeOrCornerIsReached(nextPosition, dimentions) == 1)
                {
                    ChangeDirection(nextPosition, direction, dimentions);
                }

                for (int i = 0; i < position.Length; i++)
                {
                    position[i] = nextPosition[i];
                }
            }
        }
        static void ChangeDirection(int[] nextPosition, int[] direction, int[] dimentions)
        {
            for (int i = 0; i < dimentions.Length; i++)
            {
                if (nextPosition[i] == 1 && direction[i] == -1)
                {
                    direction[i] *= -1;
                }
                else if (nextPosition[i] == dimentions[i] && direction[i] == 1)
                {
                    direction[i] *= -1;
                }
            }
        }
        static int[] ReadData(string data)
        {
            int[] result = data.Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries).Select(x=>int.Parse(x)).ToArray();
            return result;
        }
        static int CheckIfEdgeOrCornerIsReached(int[] position, int[] dimentions)
        {
            int countCorners = 0;
            //if counter = 1 wall is reached, 2 edge, 3 corner

            for (int i = 0; i < position.Length; i++)
            {
                if (position[i] == dimentions[i] || position[i] == 1)
                {
                    countCorners++;
                }
            }
            return countCorners;
        }
    }
}
