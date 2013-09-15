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
        StringBuilder message = new StringBuilder();
        message.Append(Console.ReadLine());
        string cypher = Console.ReadLine();

        Encrypt(message, cypher);
    }
    static void Encrypt(StringBuilder message, string cypher)
    {
        if (cypher.Length > message.Length)
        {
            for (int i = 0, j = 0; i < cypher.Length; i++, j++)
            {
                j = i % message.Length;
                message[j] = (char)(((message[j] - 65) ^ (cypher[i] - 65)) + 65);
            }
        }
        else
        {
            for (int i = 0, j = 0; i < message.Length; i++, j++)
            {
                j = i % cypher.Length;
                message[i] = (char)(((message[i] - 65) ^ (cypher[j] - 65)) + 65);
            }
        }

        message.Append(cypher);

        Encode(message, cypher);
    }
    static void Encode(StringBuilder message, string cypher)
    {
        StringBuilder current = new StringBuilder();
        char currentChar = '\0';
        char previousChar = message[0];
        int currentLength = 1;

        for (int i = 1; i < message.Length; i++)
        {
            currentChar = message[i];

            if (currentChar == previousChar)
            {
                currentLength++;
            }
            else
            {
                if (currentLength > 2)
                {
                    current.Append(currentLength);
                    current.Append(previousChar);
                    currentLength = 1;
                    previousChar = currentChar;
                }
                else
                {
                    for (int j = 0; j < currentLength; j++)
                    {
                        current.Append(previousChar);
                    }
                    currentLength = 1;
                    previousChar = currentChar;
                }
            }
        }
        //one more time for the last letter or sequence. otherwise its not appended
        if (currentLength > 2)
        {
            current.Append(currentLength);
            current.Append(previousChar);
            currentLength = 1;
            previousChar = currentChar;
        }
        else
        {
            for (int j = 0; j < currentLength; j++)
            {
                current.Append(previousChar);
            }
            currentLength = 1;
            previousChar = currentChar;
        }

        Console.WriteLine("{0}{1}", current, cypher.Length);
    }
}
