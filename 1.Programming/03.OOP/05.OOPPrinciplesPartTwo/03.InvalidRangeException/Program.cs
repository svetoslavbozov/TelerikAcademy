using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.InvalidRangeException
{
    class Program
    {
        static int startInt = 1;
        static int endInt = 100;
        static DateTime startDate = new DateTime(1980, 1, 1);
        static DateTime endDate = new DateTime(2013, 12, 31);

        static void Main(string[] args)
        {
            ReadNumberInRange();
            ReadDateInRange();
        }
        static void ReadNumberInRange()
        {
            Console.Write("Enter int [{0}..{1}]: ", startInt, endInt);
            int number = int.Parse(Console.ReadLine());

            if (number < startInt || number > endInt)
            {
                throw new InvalidRangeException<int>("Invalid range");
            }
        }

        static void ReadDateInRange()
        {
            Console.Write("Enter date in range [{0}..{1}]: ", startDate.ToShortDateString(), endDate.ToShortDateString());
            DateTime number = DateTime.Parse(Console.ReadLine());

            if (number < startDate || number > endDate)
            {
                throw new InvalidRangeException<DateTime>("Invalid range");
            }
        }
    }
}
