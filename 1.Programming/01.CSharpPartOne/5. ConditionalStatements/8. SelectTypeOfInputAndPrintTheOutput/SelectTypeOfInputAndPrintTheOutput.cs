using System;

class SelectTypeOfInputAndPrintTheOutput
{
    static void Main()
    {
        Console.WriteLine("Select input type 1/2/3 for int/double/string: ");
        int inputChoice = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter your input: ");
        string input = Console.ReadLine();

        switch (inputChoice)
        {
            case 1:
                Console.WriteLine(Convert.ToInt32(input) + 1);
                break;
            case 2:
                Console.WriteLine(Convert.ToDouble(input) + 1);
                break;
            case 3:
                Console.WriteLine(input + "*");
                break;

            default:
                Console.WriteLine("Invalid input");
                break;
        }
    }
}

