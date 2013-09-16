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

        Dictionary<string, int> numbers = new Dictionary<string, int>
            {
                {"CHU",0}, {"TEL",1}, {"OFT",2}, {"IVA",3}, {"EMY",4}, {"VNB",5}, {"POQ",6}, {"ERI",7}, {"CAD",8}, {"K-A",9}, {"IIA",10}, {"YLO",11}, {"PLA",12}
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
            power *= 13;
        }

        return power;
    }
}

