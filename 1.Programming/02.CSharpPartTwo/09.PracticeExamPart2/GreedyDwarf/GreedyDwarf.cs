using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedyDwarf
{
    class GreedyDwarf
    {
        static void Main(string[] args)
        {
            int[] path = Console.ReadLine().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => Convert.ToInt32(x)).ToArray();

            int patternsCount = int.Parse(Console.ReadLine());

            int score = 0;
            int bestScore = int.MinValue;

            for (int i = 0; i < patternsCount; i++)
            {
                int[] currentPath = path;
                int[] pattern = Console.ReadLine().Split(new[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries).Select(x => Convert.ToInt32(x)).ToArray();

                score = 0;
                int currentPosition = 0;

                score += currentPath[0];
                currentPath[0] = 0;

                for (int j = 0; j < pattern.Length; j++)
                {
                    currentPosition += pattern[j];

                    if (currentPosition >= currentPath.Length || currentPosition < 0 || currentPath[currentPosition] == 0)
                    {
                        if (score > bestScore)
                        {
                            bestScore = score;
                            score = int.MinValue;
                        }
                        break;
                    }

                    score += currentPath[currentPosition];
                    currentPath[currentPosition] = 0;

                    if (j == pattern.Length - 1)
                    {
                        j = -1;
                    }
                }
            }
            Console.WriteLine(bestScore);
        }
    }
}