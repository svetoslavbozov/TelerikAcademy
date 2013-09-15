using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indices
{
    class Indices
    {
        static long[] array;
        static bool[] isVisited;
        static List<long> sequence = new List<long>();
        static StringBuilder result = new StringBuilder();
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            array = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(x => Convert.ToInt64(x)).ToArray();
            isVisited = new bool[array.Length];

            GoToNext(0);

            Console.WriteLine();
        }
        static void GoToNext(long index)
        {
            if (index < array.Length && index >= 0)
            {
                if (!isVisited[index])
                {
                    isVisited[index] = true;
                    sequence.Add(index);
                    GoToNext(array[index]);
                }
                else
                {
                    for (int i = 0; i < sequence.Count; i++)
                    {
                        if (sequence[i] == index)
                        {
                            Console.Write("(");
                            Console.Write(sequence[i]);
                            continue;
                        }
                        if (i <= sequence.Count - 1 && i > 0)
                        {
                            Console.Write(" ");
                        }

                        Console.Write(sequence[i]);
                    }
                    Console.Write(")");
                }
            }
            else
            {
                foreach (var item in sequence)
                {
                    result.Append(item).Append(" ");
                }
                Console.WriteLine(result.ToString().Trim());
            }
        }
    }
}
