using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Employees
{
    class Workers
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Value { get; set; }

        public Workers(string firstName, string lastName, int value)
        {
            FirstName = firstName;
            LastName = lastName;
            Value = value;
        }
    }
    class Employees
    {
        static void Main(string[] args)
        {
            if (File.Exists("input.txt"))
            {
                Console.SetIn(new StreamReader("input.txt"));
            }

            int positionsCount = int.Parse(Console.ReadLine());

            Dictionary<string, int> positions = new Dictionary<string, int>();

            while (positionsCount > 0)
            {
                string[] current = Console.ReadLine().Split(new[] {" - "},StringSplitOptions.None);

                if (!positions.ContainsKey(current[0]))
                {
                    positions.Add(current[0], int.Parse(current[1]));
                }

                positionsCount--;
            }

            int workersCount = int.Parse(Console.ReadLine());

            List<Workers> idiots = new List<Workers>();

            while (workersCount > 0)
            {
                string[] currentWorker = Console.ReadLine().Split(new[] { " - " }, StringSplitOptions.RemoveEmptyEntries);

                string[] names = currentWorker[0].Split(' ');


                idiots.Add(new Workers(names[0], names[1], positions[currentWorker[1]]));

                workersCount--;
            }

            idiots = idiots.OrderByDescending(x => x.Value).ThenBy(x => x.LastName).ThenBy(x => x.FirstName).ToList();

            foreach (var item in idiots)
            {
                Console.WriteLine("{0} {1}", item.FirstName, item.LastName);
            }

        }
    }
}
