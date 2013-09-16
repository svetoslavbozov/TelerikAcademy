using System;

class CalculateSumWithAccuracy
{
    static void Main()
    {
        float i = 2.0f;
        float sum = 1.0f;
        float temp = 0.0f;
        float tempSum = 0.0f;

        do
        {
            tempSum = sum;
            if (i % 2 == 0)
            {
                temp = 1 / i;
            }
            else
            {
                temp = -1 / i;
            }
            sum = sum + temp;
            i++;

        } while (tempSum != sum);
        Console.WriteLine("{0:0.000}", sum);
    }
}