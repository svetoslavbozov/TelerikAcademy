using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brackets
{
    class Bracket
    {
        static long result = 0;
        static void Main(string[] args)
        {
            string brackets = "??????????????????????????????";
            Brackets(brackets.Length);
            Console.WriteLine();
        }
        static void Brackets(int n)
        {            
                Brackets(0, 0, n/2);            
        }
        static void Brackets(int open, int close, int pairs)
        {
            if ((open == pairs) && (close == pairs))
            {
                result++;
            }
            else
            {
                if (open < pairs)
                    Brackets( open + 1, close, pairs);
                if (close < open)
                    Brackets( open, close + 1, pairs);
            }
        }
    }
}
