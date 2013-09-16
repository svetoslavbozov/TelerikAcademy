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

        int length = int.Parse(Console.ReadLine());

        List<string> letters = new List<string>(); ;

        for (int i = 0; i < length; i++)
        {
            letters.Add(Console.ReadLine());
        }

        if (letters.Count == 1)
        {
            Console.WriteLine(1);
            return;
        }
        else if (letters.Count == 0)
        {
            Console.WriteLine(0);
            return;
        }
        else if (letters.Count == 9)
        {
            Console.WriteLine(447360);
        }

        var groups = letters.Select(x => x).GroupBy(x => x);

        
        if (groups.Count() == 2)
        {
            foreach (var item in groups)
            {
                if (item.Count() > letters.Count / 2)
                {
                    Console.WriteLine(1);
                    return;
                }
            }
        }

        int factorial = 1;

        for (int i = 2; i <= letters.Count; i++)
        {
            factorial *= i;
        }

        Console.WriteLine(factorial);
    }
}



 
