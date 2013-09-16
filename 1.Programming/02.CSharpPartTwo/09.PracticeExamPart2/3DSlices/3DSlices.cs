using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _3DSlices
{
    class Program
    {
        static void Main(string[] args)
        {
        //    if (File.Exists("input.txt"))
        //    {
        //        Console.SetIn(new StreamReader("input.txt"));
        //    }

            short[] dimentions = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(x => Convert.ToInt16(x)).ToArray();

            int[, ,] cube = new int[width, height, dimentions[2]];

            int sumOfAll = 0;

            for (int H = 0; H < height; H++)
            {
                string[] line = Console.ReadLine().Split(new[] { " | " }, StringSplitOptions.RemoveEmptyEntries);

                for (int D = 0; D < dimentions[2]; D++)
                {
                    int[] current = line[D].Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(x=>int.Parse(x)).ToArray();

                    for (int W = 0; W < width; W++)
                    {
                        cube[W, H, D] = current[W];
                        sumOfAll += current[W];
                    }
                }
            }

            int counter = 0;
            int currentSum = 0;

            //po visochina
            for (int H = 0; H < height - 1; H++)
                {
                    for (int D = 0; D < dimentions[2]; D++)
                    {
                        for (int W = 0; W < width; W++)
                        {
                            currentSum += cube[W, H, D];
                        }
                    }

                    if (currentSum * 2 == sumOfAll)
                    {
                        counter++;
                    }
                }
            
            //po dalbochina
            currentSum = 0;
            for (int D = 0; D < dimentions[2] - 1; D++)
                {
                    for (int H = 0; H < height; H++)
                    {
                        for (int W = 0; W < width; W++)
                        {
                            currentSum += cube[W, H, D];
                        }
                    }

                    if (currentSum * 2 == sumOfAll)
                    {
                        counter++;
                    }
                }
            

            //po shirina
            currentSum = 0;
            
                for (int W = 0; W < width - 1; W++)
                {
                    for (int H = 0; H < height; H++)
                    {
                        for (int D = 0; D < dimentions[2]; D++)
                        {
                            currentSum += cube[W, H, D];
                        }
                    }

                    if (currentSum * 2 == sumOfAll)
                    {
                        counter++;
                    }
                }
                      

            Console.WriteLine(counter);
        }
    }
}
