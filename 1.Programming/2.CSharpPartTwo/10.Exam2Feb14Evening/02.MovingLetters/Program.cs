using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        List<Stack<char>> wordsAsLetters = new List<Stack<char>>();

        int numberOfLetters = 0;

        //foreach word fill stack of chars and add stacks to list
        foreach (var item in input)
        {
            Stack<char> current = new Stack<char>();

            numberOfLetters += item.Length;

            for (int i = 0; i < item.Length; i++)
            {
                current.Push(item[i]);
            }

            wordsAsLetters.Add(current);
        }

        StringBuilder letters = new StringBuilder();

        //pop last letter from every word until there are no more letters
        while (numberOfLetters > 0)
        {
            foreach (var item in wordsAsLetters)
            {
                if (item.Count > 0)
                {
                    letters.Append(item.Pop());
                    numberOfLetters--;
                }
            }
        }

        int length = letters.Length;

        //swap letters
        for (int i = 0; i < letters.Length; i++)
        {
            char ch = letters[i];
            int newIndex = 0;

            if (letters[i] > 96 && letters[i] < 123)
            {
                newIndex = ((letters[i] - 96) + i) % length;
            }
            else
            {
                newIndex = ((letters[i] - 64) + i) % length;
            }

            letters.Remove(i, 1);
            letters.Insert(newIndex, ch);
        }

        Console.WriteLine(letters);
    }
}
