using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _3DStars
{
    class Stars
    {
        static void Main(string[] args)
        {
            if (File.Exists("input1.txt"))
            {
                Console.SetIn(new StreamReader("input1.txt"));
            }

            short[] dimentions = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(x => Convert.ToInt16(x)).ToArray();

            char[, ,] cube = new char[width, height, dimentions[2]];

            for (int H = 0; H < height; H++)
            {
                string[] line = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                for (int D = 0; D < dimentions[2]; D++)
                {
                    char[] current = line[D].ToCharArray();

                    for (int W = 0; W < width; W++)
                    {
                        cube[W, H, D] = current[W];
                    }
                }
            }

            List<char> results = new List<char>();

            for (int H = 1; H < height - 1; H++)
            {
                for (int D = 1; D < dimentions[2] - 1; D++)
                {
                    for (int W = 1; W < width - 1; W++)
                    {
                        char current = cube[W, H, D];

                        if (cube[W, H, D] == cube[W, H + 1, D] && cube[W, H, D] == cube[W, H - 1, D] &&
                            cube[W, H, D] == cube[W, H, D + 1] && cube[W, H, D] == cube[W, H, D - 1]&&
                            cube[W, H, D] == cube[W - 1, H, D] && cube[W, H, D] == cube[W + 1, H, D])
	                    {
                            results.Add(current);
	                    }
                    }
                }
            }

            var result = results.Select(x => x).GroupBy(x => x).OrderBy(x => x.Key);
            Console.WriteLine(results.Count);
            foreach (var item in result)
            {
                Console.WriteLine("{0} {1}", item.Key, item.Count());
            }            
        }
    }
}
