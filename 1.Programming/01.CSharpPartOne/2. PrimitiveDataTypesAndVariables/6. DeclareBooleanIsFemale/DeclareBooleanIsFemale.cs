using System;

class DeclareBooleanIsFemale
{
    static void Main()
    {
        bool isFemale;

        Console.Write("Enter your gender (m/f): ");

        char gender = char.Parse(Console.ReadLine());

        if (gender == 'm' || gender == 'f')
        {
            isFemale = (gender == 'f');
            Console.WriteLine(isFemale ? "You are female" : "You are male");
        }
        else
        {            
            throw new ArgumentException("Invalid input");
        }
    }
}

