using System;

class SpellNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter number;");
        int number = int.Parse(Console.ReadLine());

        int tens = (number % 100) / 10;
        int hundreds = number / 100;
        int units = (number % 100) % 10;

        string[] specials1 = {"Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven",
                            "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen",
                            "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"};
        string[] specials2 = { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

        if ((number >= 0) && (number <= 19))
        {
            Console.WriteLine(specials1[number]);
        }
        else if ((number >= 20) && (number <= 99))
        {
            if (units > 0)
            {
                Console.WriteLine("{0} {1}", specials2[tens - 2], specials1[units]);
            }
            else
            {
                Console.WriteLine("{0}", specials2[tens - 2]);
            }
        }
        else if ((number >= 100) && (number <= 999))
        {
            Console.Write("{0} hundred ", specials1[hundreds]);

            if ((tens > 0) && (tens <= 9))
            {
                Console.Write("and {0}", specials2[tens - 2]);
            }
            if ((units > 0) && (units <= 9))
            {
                Console.WriteLine(" {0}", specials1[units]);
            }
        }
        Console.WriteLine();
    }
}

