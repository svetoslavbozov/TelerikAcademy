using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class BasicLanguage
{
    static void Main(string[] args)
    {
        if (File.Exists("input.txt"))
        {
            Console.SetIn(new StreamReader("input.txt"));
        }

        List<string> commands = new List<string>();

        StringBuilder result = new StringBuilder();

        while (true)
        {
            string line = Console.ReadLine();
            result.AppendLine(line);
            if (line.Contains("EXIT")) break;
        }

        string textString = result.ToString();
        result.Clear();

        for (int i = 0; i < textString.Length; i++)
        {
            result.Append(textString[i]);

            if (textString[i] == ';')
            {
                commands.Add(result.ToString());
                result.Clear();
            }
        }

        result.Clear();

        long repeat = 1;

        for (int i = 0; i < commands.Count; i++)
        {
            string[] currentLine = commands[i].Split(')');

            for (int j = 0; j < currentLine.Length; j++)
            {
                string currentCommand = currentLine[j].TrimStart();

                if (currentCommand.StartsWith("FOR"))
                {
                    int[] loopLength = currentCommand.Substring(currentCommand.IndexOf("(") + 1).Split(',').Select(x => int.Parse(x)).ToArray();

                    if (loopLength.Length > 1)
                    {
                        repeat *= (loopLength[1] - loopLength[0]) + 1;
                    }
                    else
                    {
                        repeat *= loopLength[0];
                    }

                }
                else if (currentCommand.StartsWith("PRINT"))
                {
                    string content = currentCommand.Substring(currentCommand.IndexOf("(") + 1);

                    for (int p = 0; p < repeat; p++)
                    {
                        result.Append(content);
                    }

                    repeat = 1;
                }
                else if (currentLine[j].StartsWith("EXIT"))
                {
                    Console.Write(result);
                    return;
                }                
            }
        }
    }
}
