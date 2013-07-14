using System;

class SortNumbersDescending
{
    static void Main()
    {
        Console.WriteLine("Enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());



        if (firstNumber < secondNumber)
        {
            if (secondNumber < thirdNumber)
            {
                Console.WriteLine("{0}, {1}, {2}", thirdNumber, secondNumber,firstNumber);                
            }
            else
            {
                if (firstNumber > thirdNumber)
                {
                    Console.WriteLine("{0}, {1}, {2}", secondNumber, firstNumber, thirdNumber);                    
                }
                else
                {
                    Console.WriteLine("{0}, {1}, {2}", secondNumber, thirdNumber, firstNumber);
                }
            }
        }
        else
        {
            if (secondNumber > thirdNumber)
            {
                Console.WriteLine("{0}, {1}, {2}", firstNumber, secondNumber, thirdNumber);
            }
            else
            {
                if (firstNumber < thirdNumber)
                {
                    Console.WriteLine("{0}, {1}, {2}", thirdNumber, firstNumber, secondNumber);
                }
                else
                {
                    Console.WriteLine("{0}, {1}, {2}", firstNumber, thirdNumber, secondNumber);
                }

            }
        }
    }
}

