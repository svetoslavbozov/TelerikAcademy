using System;

class NextDate
{
    static void Main()
    {
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());

        DateTime nextDay = new DateTime(year, month, day );

        nextDay = nextDay.AddDays(1);

        Console.WriteLine("{0}.{1}.{2}", nextDay.Day, nextDay.Month, nextDay.Year);
    }
}

