using System;

class DeclareAndExchangeValues
{
    static void Main()
    {
        int firstValue = 5;
        int secondValue = 10;

        int switchingVar;

        switchingVar = firstValue;
        firstValue = secondValue;
        secondValue = switchingVar;

        Console.WriteLine("First value is {0} second is {1}", firstValue, secondValue);
    }
}

