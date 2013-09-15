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
        if (File.Exists("input.txt"))
        {
            Console.SetIn(new StreamReader("input.txt"));
        }

        int numberOfWords = int.Parse(Console.ReadLine());
        List<string> words = new List<string>();

        while (numberOfWords > 0)
        {
            words.Add(Console.ReadLine());
            numberOfWords--;
        }

        for (int i = 0; i < words.Count; i++)
        {
            string currentWord = words[i];
            int newIndexer = (words[i].Length % (words.Count + 1));
            words[i] = null;
            words.Insert(newIndexer, currentWord);
            words.Remove(null);
        }

        int length = words.OrderBy(x=>x.Length).Last().Length;

        StringBuilder result = new StringBuilder();

        for (int i = 0; i < length; i++)
        {
            foreach (var item in words)
            {
                if (item.Length > i)
                {
                    result.Append(item[i]);
                }
            }
        }

        Console.WriteLine(result);

    }
}
