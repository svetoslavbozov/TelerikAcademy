using System;

class CreateAlphabetArray
{
    static void Main()
    {
        int lettersCount = 52;
        char[] array = new char[lettersCount];

        for (int i = 0; i < lettersCount; i++)
        {
            if (i<=25)
            {
                array[i] = (char)(i + 97); // lower letters
            }
            else
            {
                array[i] = (char)(i + 39); // upper letters
            }            
        }      

        Console.WriteLine("Enter word");
        string word = Console.ReadLine();

        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] > 90)
            {
                Console.Write((int)(word[i] - 97)); // lower letters
            }
            else
            {
                Console.Write((int)(word[i] - 39)); // upper letters
            }
            if (i != word.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}

