using System;

class DeclareAndConcatenateStrings
{
    static void Main()
    {
        string firstString = "Hello";
        string secondString = "World";

        object concatenatedStrings = firstString + " " + secondString;

        string thirdString = Convert.ToString(concatenatedStrings);

        Console.WriteLine(thirdString);
    }
}

