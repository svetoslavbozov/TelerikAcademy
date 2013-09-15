using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyTasks
{
    class AcademyTasks
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(x => Convert.ToInt32(x)).ToArray();
            int pleasantness = int.Parse(Console.ReadLine());

            int maxPleasantness = int.MinValue;
            int minPleasantness = int.MaxValue;
            int counter = 0;
            bool found = false;

            for (int i = 0; i < array.Length; i++)
            {
                counter++;

                if (array[i] > maxPleasantness)
                {
                    maxPleasantness = array[i];
                }
                if (array[i] < minPleasantness)
                {
                    minPleasantness = array[i];
                }

                if ((maxPleasantness - minPleasantness) >= pleasantness)
                {
                    found = true;
                    break;
                }
            }

            if (found)
            {
                Console.WriteLine((counter/2) + 1);
            }
            else
            {
                Console.WriteLine(array.Length);
            }
        }
    }
}