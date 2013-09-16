using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GenomeDecoder
{
    class GenomeDecoder
    {
        static void Main(string[] args)
        {
            if (File.Exists("input.txt"))
            {
                Console.SetIn(new StreamReader("input.txt"));
            }

            int[] linesAndGroups = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            string genome = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            string number = null;

            for (int i = 0; i < genome.Length; i++)
            {
                if (char.IsDigit(genome[i]))
                {
                    number += genome[i];
                }
                else
                {
                    if (number == null)
                    {
                        number = "1";
                    }

                    result.Append(new string(genome[i], int.Parse(number)));
                    number = null;
                }
            }

            genome = result.ToString();
            result.Clear();

            int maxRowNumber = (int)Math.Ceiling((decimal)genome.Length / (decimal)linesAndGroups[0]);
            int padSize = maxRowNumber.ToString().Length;

            for (int i = 1; i <= maxRowNumber; i++)
            {
                result.Clear();
                result.Append(new string(' ', padSize - i.ToString().Length));
                result.Append(i);

                for (int j = (i - 1) * linesAndGroups[0]; j <= i * linesAndGroups[0] - 1; j++)
                {
                    if ((j - (i - 1) * linesAndGroups[0]) % linesAndGroups[1] == 0)
                    {
                        result.Append(' ');
                    }

                    if (j >= genome.Length)
                    {
                        break;
                    }

                    result.Append(genome[j]);
                }
                Console.WriteLine(result.ToString());
            }
        }
    }
}