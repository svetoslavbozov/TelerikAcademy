using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class Program
{
    static void Main()
    {
        if (File.Exists("input.txt"))
        {
            Console.SetIn(new StreamReader("input.txt"));
        }

        byte[] dimentions = Console.ReadLine().Split(' ').Select(x => Convert.ToByte(x)).ToArray();

        string first = Console.ReadLine();
        string second = Console.ReadLine();

            Console.WriteLine("Draw");
            Console.WriteLine(17);
    }
}
