using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Cube__3DLines
{
    class Lines
    {        
        static char[, ,] cube;
        static bool[, , , , ,] processed;
        static int lineMaxLen = 0;
        static int linesCount;
        static int W;
        static int H;
        static int D;

        static void Main(string[] args)
        {
            if (File.Exists("input1.txt"))
            {
                Console.SetIn(new StreamReader("input1.txt"));
            }

            short[] dimentions = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(x => Convert.ToInt16(x)).ToArray();

            W = dimentions[0];
            H = dimentions[1];
            D = dimentions[2];

            cube = new char[dimentions[0], dimentions[1], dimentions[2]];

            for (int h = 0; h < dimentions[1]; h++)
            {
                string[] line = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                for (int d = 0; d < dimentions[2]; d++)
                {
                    char[] current = line[d].ToCharArray();

                    for (int w = 0; w < dimentions[0]; w++)
                    {
                        cube[w, h, d] = current[w];
                    }
                }
            }

            FindLongestLine();

            // Print the result
            if (lineMaxLen > 1)
            {
                Console.WriteLine("{0} {1}", lineMaxLen, linesCount);
            }
            else
            {
                Console.WriteLine(-1);
            }
        }
        private static void FindLongestLine()
        {
            processed = new bool[W, H, D, 3, 3, 3];

            for (int startW = 0; startW < W; startW++)
            {
                for (int startH = 0; startH < H; startH++)
                {
                    for (int startD = 0; startD < D; startD++)
                    {
                        ProcessLinesInAllDirections(startW, startH, startD);
                    }
                }
            }
        }
        private static void ProcessLinesInAllDirections(int startW, int startH, int startD)
        {
            for (int stepW = -1; stepW <= 1; stepW++)
            {
                for (int stepH = -1; stepH <= 1; stepH++)
                {
                    for (int stepD = -1; stepD <= 1; stepD++)
                    {
                        ProcessLine(startW, startH, startD, stepW, stepH, stepD);
                    }
                }
            }
        }
        private static void ProcessLine(int w, int h, int d, int stepW, int stepH, int stepD)
        {
            if (stepW == 0 && stepH == 0 && stepD == 0)
            {
                return; // Invalid direction vector {0, 0, 0}
            }

            if (IsProcessed(w, h, d, stepW, stepH, stepD))
            {
                return; // The given start location and direction is already processed
            }

            char color = cube[w, h, d];
            int len = 0;

            // Find the end of the line
            while ((IsInsideTheCuboid(w + stepW, h + stepH, d + stepD)) && (cube[w + stepW, h + stepH, d + stepD] == color))
            {
                w += stepW;
                h += stepH;
                d += stepD;
            }

            // Scan the line back from the end to the start
            while (IsInsideTheCuboid(w, h, d) && cube[w, h, d] == color)
            {
                MarkAsProcessed(w, h, d, stepW, stepH, stepD);
                len++;

                if (len == lineMaxLen)
                {
                    linesCount++;
                }
                else if (len > lineMaxLen)
                {
                    lineMaxLen = len;
                    linesCount = 1;
                }

                w -= stepW;
                h -= stepH;
                d -= stepD;
            }
        }
        private static bool IsProcessed(int w, int h, int d, int stepW, int stepH, int stepD)
        {
            return processed[w, h, d, stepW + 1, stepH + 1, stepD + 1] || processed[w, h, d, -stepW + 1, -stepH + 1, -stepD + 1]; 
        }

        private static void MarkAsProcessed(int w, int h, int d, int stepW, int stepH, int stepD)
        {
            processed[w, h, d, stepW + 1, stepH + 1, stepD + 1] = true;
            processed[w, h, d, -stepW + 1, -stepH + 1, -stepD + 1] = true;
        }

        private static bool IsInsideTheCuboid(int w, int h, int d)
        { 
            return w >= 0 && w < W && h >= 0 && h < H && d >= 0 && d < D;
        }
    }
}