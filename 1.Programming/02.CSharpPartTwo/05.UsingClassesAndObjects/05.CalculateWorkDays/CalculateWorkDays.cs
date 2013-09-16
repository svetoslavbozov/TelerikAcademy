/*Write a method that calculates the number of workdays between today and given date, passed as parameter. Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.*/

using System;
class CalculateWorkDays
{
    static void Main()
    {
        Console.WriteLine("Enter end day");
        int day = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter end month");
        int month = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter end year");
        int year = int.Parse(Console.ReadLine());
        DateTime endDay = new DateTime(year, month, day);
        
        //start day is today
        DateTime startDay = DateTime.Today;

        //swap start and end date if end date is in the past
        if (startDay > endDay)
        {
            startDay = endDay;
            endDay = DateTime.Today;
        }

        //add some holidays in this array (these are not correct!)
        DateTime[] holidays =
            {
                new DateTime(2013, 1, 2),
                new DateTime(2013, 2, 26),
                new DateTime(2013, 3, 4),
                new DateTime(2013, 1, 4),
            };

        int timeLen = Math.Abs((endDay - startDay).Days);
        int workDayCounter = 0;

        for (int i = 0; i < timeLen; i++)
        {
            startDay = startDay.AddDays(1);
            //check if its not working day
            if (startDay.DayOfWeek != DayOfWeek.Sunday && startDay.DayOfWeek != DayOfWeek.Saturday)
            {
                //check if its holiday
                if (!IsHoliday(startDay, holidays))
                {
                    workDayCounter++;
                }
            }
        }

        Console.WriteLine(workDayCounter);
    }

    static bool IsHoliday(DateTime startDay, DateTime[] holidays)
    {
        for (int j = 0; j < holidays.Length; j++)
        {
            if (startDay.Day == holidays[j].Day && startDay.Month == holidays[j].Month)
            {
                return true;
            }
        }

        return false;
    }
}

