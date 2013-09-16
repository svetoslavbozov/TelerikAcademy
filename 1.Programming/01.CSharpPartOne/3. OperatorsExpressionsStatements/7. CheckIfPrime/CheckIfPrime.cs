using System;

class CheckIfPrime
{
    static void Main()
    {
        Console.WriteLine("Enter number:");
        int number = int.Parse(Console.ReadLine());

        int divider = 2;
        int maxDivider = (int)Math.Sqrt(number);
        bool isPrime = true;

        while (isPrime && (divider <= maxDivider))
        {
            if (number % divider == 0)
            {
                isPrime = false;
            }
            divider++;
        }

        Console.WriteLine("Is prime ? " + isPrime);        
    }
}

