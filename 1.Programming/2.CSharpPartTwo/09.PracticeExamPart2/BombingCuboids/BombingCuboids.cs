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
        static byte width ;
        static byte height;
        static byte depth;

        static void Main(string[] args)
        {
            if (File.Exists("input.txt"))
            {
                Console.SetIn(new StreamReader("input.txt"));
            }

            byte[] dimentions = Console.ReadLine().Split(' ').Select(x => Convert.ToByte(x)).ToArray();

            width = dimentions[0];
            height = dimentions[1];
            depth = dimentions[2];

            char[, ,] cube = new char[width, height, depth];

            for (byte H = 0; H < height; H++)
            {
                string[] line = Console.ReadLine().Split(' ');

                for (byte D = 0; D < depth; D++)
                {
                    string current = line[D];

                    for (byte W = 0; W < width; W++)
                    {
                        cube[W, H, D] = current[W];
                    }
                }
            }

            byte numberOfBombs = byte.Parse(Console.ReadLine());

            string[] bombsInfo = new string[numberOfBombs];

            for (byte i = 0; i < numberOfBombs; i++)
            {
                bombsInfo[i] = Console.ReadLine();
            }

            List<char> destroyed = new List<char>();
            int[] des = new int[26];

            //za vsqka bomba
            for (byte i = 0; i < numberOfBombs; i++)
            {
                byte[] currentBomb = bombsInfo[i].Split(' ').Select(x=>byte.Parse(x)).ToArray();
                //za celiq kub
                for (byte H = 0; H < height; H++)
                {
                    for (byte D = 0; D < depth; D++)
                    {
                        for (byte W = 0; W < width; W++)
                        {
                            //ako ne e unishtojen ve4e i e na evklidovo razstoqnie
                            if (char.IsLetter(cube[W, H, D]) && IsAtEuclidianDistance(W, H, D, currentBomb[0], currentBomb[1], currentBomb[2], currentBomb[3]))
                            {
                                //destroyed.Add(cube[W, H, D]);
                                des[cube[W, H, D] - 'A'] += 1;
                                cube[W, H, D] = '\0';
                            }
                        }
                    }
                }

                cube = DropTheBoxes(cube);
            }

            int blblblb = 0;
            for (int i = 0; i < des.Length; i++)
            {
                blblblb += des[i];
            }

            Console.WriteLine(blblblb);

            for (char color = 'A'; color <= 'Z'; color++)
            {
                int count = des[color - 'A'];
                if (count > 0)
                {
                    Console.WriteLine("{0} {1}", color, count);
                }
            }
            //Console.WriteLine(destroyed.Count);

            //var results = destroyed.Select(x => x).GroupBy(x => x).OrderBy(x=>x.Key);

            //foreach (var item in results)
            //{
            //    Console.WriteLine("{0} {1}", item.Key, item.Count());
            //}            
        }
        static bool IsAtEuclidianDistance(byte pointW, byte pointH, byte pointD, byte bombW, int bombH, byte bombD,int power)
        {
            return power >= Math.Sqrt(((pointW - bombW)*(pointW - bombW)) + (pointH - bombH)*(pointH - bombH) + (pointD - bombD)*(pointD - bombD));
        }
        static char[, ,] DropTheBoxes(char[,,] cube)
        {
            char[, ,] newCube = new char[width, height, depth];

            for (byte D = 0; D < cube.GetLength(2); D++)
            {
                for (byte W = 0; W < cube.GetLength(0); W++)
                {
                    byte offset = 0;

                    for (byte H = 0; H < cube.GetLength(1); H++)
                    {
                        if (!char.IsLetter(cube[W, H, D]))
                        {
                            offset++;
                        }
                        else
                        {
                            for (byte i = H; i < cube.GetLength(1); i++)
                            {
                                newCube[W, H - offset, D] = cube[W, H, D];
                            }
                        }
                    }
                }
            }

            return newCube;
        }
    }
}
