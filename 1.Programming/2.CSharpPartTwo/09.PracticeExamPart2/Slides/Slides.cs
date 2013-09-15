using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Slides
{
    class Slides
    {
        static void Main(string[] args)
        {
            if (File.Exists("input.txt"))
            {
                Console.SetIn(new StreamReader("input.txt"));
            }
            short[] dimentions = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(x => Convert.ToInt16(x)).ToArray();

            string[, ,] cube = new string[width, height, dimentions[2]];

            for (int H = 0; H < height; H++)
            {
                string[] line = Console.ReadLine().Split(new[] { " | " }, StringSplitOptions.RemoveEmptyEntries);

                for (int D = 0; D < dimentions[2]; D++)
                {
                    string[] current = line[D].Split(new[] { "(", ")"}, StringSplitOptions.RemoveEmptyEntries);

                    for (int W = 0; W < width; W++)
                    {
                        cube[W, H, D] = current[W];
                    }
                }
            }

            short[] coordinates = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(x => Convert.ToInt16(x)).ToArray();

            int[] movesW = { -1, 1, 0, 0, -1, 1, -1, 1 };
            int[] movesD = { 0, 0, -1, 1, -1, -1, 1, 1 };

            int positionW = coordinates[0];
            int positionH = 0;
            int positionD = coordinates[1];
            
            int currentW = 0;
            int currentH = 0;
            int currentD = 0;

            while (true)
            {
                switch (cube[positionW,positionH,positionD])
                {
                    case "S L":
                        currentW = positionW + movesW[0]; 
                        currentH++; 
                        currentD = positionD + movesD[0];
                        break;
                    case "S R":
                        currentW = positionW + movesW[1]; 
                        currentH++;
                        currentD = positionD + movesD[1];
                        break;
                    case "S F":
                        currentW = positionW + movesW[2]; 
                        currentH++;
                        currentD = positionD + movesD[2];
                        break;
                    case "S B":
                        currentW = positionW + movesW[3]; 
                        currentH++;
                        currentD = positionD + movesD[3];
                        break;
                    case "S FL":
                        currentW = positionW + movesW[4]; 
                        currentH++;
                        currentD = positionD + movesD[4];
                        break;
                    case "S FR":
                        currentW = positionW + movesW[5]; 
                        currentH++;
                        currentD = positionD + movesD[5];
                        break;
                    case "S BL":
                        currentW = positionW + movesW[6]; 
                        currentH++;
                        currentD = positionD + movesD[6];
                        break;
                    case "S BR":
                        currentW = positionW + movesW[7]; 
                        currentH++;
                        currentD = positionD + movesD[7];
                        break;
                    case "E":
                        currentW = positionW;
                        currentH++;
                        currentD = positionD;
                        break;
                    case "B":
                        Console.WriteLine("No");
                        Console.WriteLine("{0} {1} {2}", positionW,positionH,positionD);
                        return;
                    default:
                        string[] teleport = cube[positionW, positionH, positionD].Split(new[] {" "},StringSplitOptions.RemoveEmptyEntries);
                        currentW = Convert.ToInt32(teleport[1].ToString());
                        currentD = Convert.ToInt32(teleport[2].ToString());
                        break;
                }

                if (currentH == height)
	            {
		            Console.WriteLine("Yes");
                    Console.WriteLine("{0} {1} {2}", positionW, positionH, positionD);
                    return;
	            }
                else if (CheckForWals(currentW, currentH, currentD, dimentions))
                {
                    Console.WriteLine("No");
                    Console.WriteLine("{0} {1} {2}", positionW, positionH, positionD);
                    return;
                }
                else
                {
                    positionW = currentW;
                    positionH = currentH;
                    positionD = currentD;
                }
            }

        }
        static bool CheckForWals(int currentW, int currentH, int currentD, short[] dimentions)
        {
            if (currentW == width || currentD == dimentions[2] || currentD < 0 || currentW < 0)
            {
                return true;
            }

            return false;
        }
    }
}
