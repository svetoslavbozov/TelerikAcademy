using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Problem_5_Secret_Language
{
    class Program
    {
        static void Main()
        {
            //if (File.Exists("input.txt"))
            //{
            //    Console.SetIn(new StreamReader("input.txt"));
            //}

            string sentence = Console.ReadLine();
            string[] validWords = Console.ReadLine().Split(new char[] { ' ', ',', '\"' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(Decompose(sentence, validWords));
        }

        static int Decompose(string sentence, string[] validWords)
        {
            int sentenceLength = sentence.Length;
            int validWordsCount = validWords.Length;

            string[] validSorted = new string[validWordsCount];

            for (int i = 0; i < validSorted.Length; i++)
            {
                validSorted[i] = new string(validWords[i].ToCharArray().OrderBy(x=>x).ToArray());
            }

            int[] min = new int[sentenceLength + 1];

            for (int i = 0; i < sentenceLength; i++)
            {
                min[i + 1] = 999999;
            }

            for (int i = 0; i < sentenceLength; i++)
            {
                for (int j = 0; j < validWordsCount; j++)
                {
                    if (i + 1 >= validWords[j].Length)
                    {
                        string current = sentence.Substring(i - validWords[j].Length + 1, validWords[j].Length);
                        string currentSorted = new string(current.ToCharArray().OrderBy(x => x).ToArray());

                        if (currentSorted == validSorted[j])
                        {
                            int cost = 0;

                            for (int k = 0; k < validWords[j].Length; k++)
                            {
                                if (current[k] != validWords[j][k]) cost++;
                            }

                            min[i + 1] = Math.Min(min[i + 1], min[i + 1 - validWords[j].Length] + cost);
                        }
                    }
                }
            }
            return min[sentenceLength] < 999999 ? min[sentenceLength] : -1;
        }
    }
}
