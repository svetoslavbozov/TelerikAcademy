using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crossword
{
    class Crossword
    {
        static int count;
        static bool solutionFound = false;
        static string[] currentCrossword;
        static char[] ch;
        static string[] words;

        static void Main(string[] args)
        {
            count = int.Parse(Console.ReadLine());
            words = new string[2 * count];

            for (int i = 0; i < count * 2; i++)
            {
                words[i] = Console.ReadLine();
            }

            words = words.OrderBy(x => x).ToArray();

            string[] crossword = GenerateCrossword();

            if (crossword == null)
            {
                Console.WriteLine("NO SOLUTION!");
            }
            else
            {
                foreach (string line in crossword)
                {
                    Console.WriteLine(line);
                }
            }
        }
        static string[] GenerateCrossword()
        {
            currentCrossword = new string[count];

            ch = new char[count];

            Solve(0);

            if (solutionFound)
            {
                return currentCrossword;
            }
            else
            {
                return null;
            }
        }
        static void Solve(int currentIndex)
        {
            if (currentIndex == count)
            {
                bool isOK = true;

                for (int i = 0; i < count; i++)
                {
                    for (int j = 0; j < count; j++)
                    {
                        ch[j] = currentCrossword[j][i];
                    }

                    if (!words.Contains(new string(ch)))
                    {
                        isOK = false;
                        break;
                    }
                }
                if (isOK)
                {
                    solutionFound = true;
                }
                return;
            }

            for (int i = 0; i < words.Length; i++)
            {
                currentCrossword[currentIndex] = words[i];
                Solve(currentIndex + 1);
                if (solutionFound) return;
            }
        }
    }
}
