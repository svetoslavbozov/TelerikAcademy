/*Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and has the same functionality as Substring in the class String.
*/

using System;
using System.Text;

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
