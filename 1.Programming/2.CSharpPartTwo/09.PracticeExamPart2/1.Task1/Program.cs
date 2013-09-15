using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Numerics;

class Program
{
    static void Main()
    {
        if (File.Exists("input.txt"))
        {
            Console.SetIn(new StreamReader("input.txt"));
        }

        Dictionary<string,int> numbers = new Dictionary<string,int>
            {
                {"Rawr",0}, {"Rrrr",1}, {"Hsst",2}, {"Ssst",3}, {"Grrr",4}, {"Rarr",5}, {"Mrrr",6}, {"Psst",7}, {"Uaah",8}, {"Uaha",9}, {"Zzzz",10}, {"Bauu",11}, {"Djav",12}, {"Myau",13}, {"Gruh",14}
            };

            string gagNumber = Console.ReadLine();

            Stack<int> decimalNumbers = new Stack<int>();

            StringBuilder currentNumber = new StringBuilder();

            for (int i = 0; i < gagNumber.Length; i++)
            {
                currentNumber.Append(gagNumber[i]);

                if (numbers.ContainsKey(currentNumber.ToString()))
                {
                    decimalNumbers.Push(numbers[currentNumber.ToString()]);
                    currentNumber.Clear();
                }
            }

            BigInteger result = 0;
            int counter = 0;

            while (0 < decimalNumbers.Count)
            {
                result += decimalNumbers.Pop() * ReturnPower(counter++);
            }

            Console.WriteLine(result);
        }
        static BigInteger ReturnPower(int i)
        {
            BigInteger power = 1;

            for (int j = 0; j < i; j++)
            {
                power *= 15;
            }

            return power;
        }
    }

