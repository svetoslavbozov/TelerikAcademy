using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace KaspichanNumbers
{
    class KaspichanNumbers
    {
        static void Main(string[] args)
        {
            string[] smallChars = { "", "a", "b", "c", "d", "e", "f", "g", "h", "i" };
            string[] bigChars = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };


            BigInteger number = BigInteger.Parse(Console.ReadLine());

            List<string> letters = new List<string>();

            StringBuilder num = new StringBuilder();

            int counter = 256;
            
            for (int i = 0; i < smallChars.Length; i++)
            {
                for (int j = 0; j < bigChars.Length; j++)
                {
                    if (counter > 0)
	                {
                        num.Append(smallChars[i]).Append(bigChars[j]);
                        letters.Add(num.ToString());
                        num.Clear();
                        counter--;
                    }
                }
            }

            List<string> result = new List<string>();

            if (number == 0)
            {
                Console.WriteLine("A");
            }
            else
            {
                while (number > 0)
                {
                    int reminder = (int)(number % 256);
                    num.Insert(0, letters[reminder]);
                    number /= 256;
                }

                Console.WriteLine(num);
            }
        }
    }
}
