using System;
using System.Linq;

class AstrologicalDigits
{
    static void Main()
    {
        string n = Console.ReadLine();

        int sum = n.ToString().Replace("-", "").Replace(".", "").Sum(c => c - '0');        

        while (sum > 9)
        {
            sum = sum.ToString().Sum(c => c - '0');
        }      

        Console.WriteLine(sum);
    }
}

