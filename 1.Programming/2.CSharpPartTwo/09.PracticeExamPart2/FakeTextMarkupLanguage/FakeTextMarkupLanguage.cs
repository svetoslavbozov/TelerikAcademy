using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FakeTextMarkupLanguage
{
    class FakeTextMarkupLanguage
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            StringBuilder text = new StringBuilder();

            while (lines > 0)
            {
                text.AppendLine(Console.ReadLine());
                lines--;
            }

            string htmnlText = text.ToString();

            text.Clear();

            Stack<char> commands = new Stack<char>();
            Stack<string> currentText = new Stack<string>();

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < htmnlText.Length; i++)
            {
                if (htmnlText[i] == '<')
                {
                    currentText.Push(text.ToString());
                    text.Clear();
                    if (htmnlText[i + 1] == '/')
                    {
                        string newText = ManipulateText(commands.Pop(), currentText.Pop());

                        if (currentText.Count > 0)
                        {
                            currentText.Push(currentText.Pop() + newText);
                        }
                        else
                        {
                            currentText.Push(newText);
                        }

                        text.Append(currentText.Pop());

                        while (htmnlText[i] != '>')
                        {
                            i++;
                        }
                    }
                    else
                    {
                        commands.Push(htmnlText[i + 1]);

                        i++;

                        while (htmnlText[i] != '>')
                        {
                            i++;
                        }
                    }
                }
                else if (commands.Count == 0)
                {                    
                    result.Append(text);
                    text.Clear();                    

                    result.Append(htmnlText[i]);
                }
                else
                {
                    text.Append(htmnlText[i]);
                }
            }

            Console.WriteLine(result.ToString());
            File.WriteAllText("text.txt", result.ToString());
        }
        static string ManipulateText(char command, string text)
        {
            switch (command)
            {
                case 'u':
                    return text.ToUpper();
                case 'l':
                    return text.ToLower();
                case 'd':
                    return String.Empty;
                case 'r':
                    return new string(text.Reverse().ToArray());
                case 't':
                    string result = string.Empty;

                    foreach (var item in text)
                    {
                        if (char.IsLower(item))
                        {
                            result += char.ToUpper(item);
                        }
                        else
                        {
                            result += char.ToLower(item);
                        }
                    }
                    return result;
                default:
                    return text;
            }
        }
    }
}
