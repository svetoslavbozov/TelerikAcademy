using System;
using System.Collections.Generic;

class Anacci
{
    static void Main()
    {
        char firstLetter = char.Parse(Console.ReadLine());
        char secondLetter = char.Parse(Console.ReadLine());
        int lines = int.Parse(Console.ReadLine());

        int firstLetterValue = firstLetter - 64;
        int secondLetterValue = secondLetter - 64;        

        List<char> letters = new List<char>();

        letters.Add(firstLetter);
        letters.Add(secondLetter);

        for (int i = 0; i < (2 * lines) - 2; i++)
		{
			int nextLetterValue = (firstLetterValue + secondLetterValue) % 26;
            if (nextLetterValue == 0)
            {
                nextLetterValue = 26;
            }
            firstLetterValue = secondLetterValue;
            secondLetterValue = nextLetterValue;

            letters.Add((char)(nextLetterValue + 64));
		}

        int charIndex = 1;
        int spaces = 0;

        Console.WriteLine(letters[0]);

        for (int i = 1; i < lines; i++)
        {
            Console.Write(letters[charIndex++]);
            Console.Write(new String(' ', spaces++));
            Console.WriteLine(letters[charIndex++]);            
        }
    }       
}

