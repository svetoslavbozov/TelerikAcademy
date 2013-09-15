using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BombingCuboids
{
    class BombingCuboids
    {
        static void Main(string[] args)
        {
            //if (File.Exists("input.txt"))
            //{
            //    Console.SetIn(new StreamReader("input.txt"));
            //}

            short[] dimentions = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(x => Convert.ToInt16(x)).ToArray();

            char[, ,] cube = new char[dimentions[0], dimentions[1], dimentions[2]];

            for (int H = 0; H < dimentions[1]; H++)
            {
                string[] line = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                for (int D = 0; D < dimentions[2]; D++)
                {
                    char[] current = line[D].ToCharArray();

                    for (int W = 0; W < dimentions[0]; W++)
                    {
                        cube[W, H, D] = current[W];
                    }
                }
            }

            int numberOfBombs = int.Parse(Console.ReadLine());

            string[] bombsInfo = new string[numberOfBombs];

            for (int i = 0; i < numberOfBombs; i++)
            {
                bombsInfo[i] = Console.ReadLine();
            }

            List<char> destroyed = new List<char>();

            //za vsqka bomba
            for (int i = 0; i < numberOfBombs; i++)
            {
                int[] currentBomb = bombsInfo[i].Split(new[] {" "},StringSplitOptions.RemoveEmptyEntries).Select(x=>int.Parse(x)).ToArray();
                //za celiq kub
                for (int H = 0; H < dimentions[1]; H++)
                {
                    for (int D = 0; D < dimentions[2]; D++)
                    {
                        for (int W = 0; W < dimentions[0]; W++)
                        {
                            //ako ne e unishtojen ve4e i e na evklidovo razstoqnie
                            if (cube[W, H, D] != '-' && cube[W, H, D] != '*' && IsAtEuclidianDistance(W, H, D, currentBomb[0], currentBomb[1], currentBomb[2], currentBomb[3]))
                            {
                                destroyed.Add(cube[W, H, D]);
                                cube[W, H, D] = '-';
                            }
                        }
                    }
                }

                cube = DropTheBoxes(cube);
                //printCub(cube);
                //Console.WriteLine();
            }

            Console.WriteLine(destroyed.Count);

            var results = destroyed.Select(x => x).GroupBy(x => x).OrderBy(x=>x.Key);

            foreach (var item in results)
            {
                Console.WriteLine("{0} {1}", item.Key, item.Count());
            }            
        }
        static bool IsAtEuclidianDistance(int pointW, int pointH, int pointD, int bombW, int bombH, int bombD,int power)
        {
            return power >= Math.Sqrt(((pointW - bombW)*(pointW - bombW)) + (pointH - bombH)*(pointH - bombH) + (pointD - bombD)*(pointD - bombD));
        }
        static char[, ,] DropTheBoxes(char[,,] cube)
        {
            char[, ,] newCube = new char[cube.GetLength(0), cube.GetLength(1), cube.GetLength(2)];

            for (int H = 0; H < cube.GetLength(1); H++)
            {
                for (int D = 0; D < cube.GetLength(2); D++)
                {
                    for (int W = 0; W < cube.GetLength(0); W++)
                    {
                        if (cube[W, H, D] == '-')
                        {
                            newCube[W, H, D] = cube[W, cube.GetLength(1) - 1 - H, D];
                            cube[W, cube.GetLength(1) - 1 - H, D] = '*';
                        }
                        else
                        {
                            newCube[W, H, D] = cube[W, H, D];
                        }
                    }
                }
            }

            return newCube;
        }
		static void printCub(char[,,]cube)
        {
            for (int H = 0; H < cube.GetLength(1); H++)
            {
                for (int D = 0; D < cube.GetLength(2); D++)
                {
                    for (int W = 0; W < cube.GetLength(0); W++)
                    {
                        Console.Write(cube[W, H, D]);
                    }

                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
