using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ImplementSubstring
{
    class ImplementSubstring
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder("adwadwadwadawdawdadwawdawdawd");

            StringBuilder result = text.Substring(0, 3);

            Console.WriteLine(result);
        }
    }
}
