using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _9GagNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> numbers = new Dictionary<string,int>
            {
                {"-!",0}, {"**",1}, {"!!!",2}, {"&&",3}, {"&-",4}, {"!-",5}, {"*!!!",6}, {"&*!",7}, {"!!**!-",8}
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
                power *= 9;
            }

            return power;
        }
    }
}
