using System;
using System.Text;
using System.IO;

class CleanCode
{
    static void Main()
    {
        //if (File.Exists("input.txt"))
        //{
        //    Console.SetIn(new StreamReader("input.txt"));
        //}

        StringBuilder code = new StringBuilder();

        int lines = int.Parse(Console.ReadLine());

        while (lines > 0)
        {
            code.AppendLine(Console.ReadLine());
            lines--;
        }

        string all = code.ToString();
        code.Clear();

        for (int i = 0; i < all.Length; i++)
        {
            if (!char.IsLetter(all[i]))
            {
                if (all[i] == '"')
                {
                    while (all[i] != ';' && (all[i-1] != ')' || all[i-1] != '"'))
                    {
                        code.Append(all[i++]);
                    }
                }
                if (all[i] == '/' && all[i + 1] == '/')
                {
                    while (all[i] != '\r')
                    {
                        i++;
                    }
                }
                else if (all[i] == '/' && all[i + 1] == '*')
                {
                    i = all.IndexOf("*/",i) + 1;
                    continue;
                }
            }
            code.Append(all[i]);

        }
        string[] result = code.ToString().Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < result.Length; i++)
		{
            result[i] = result[i].TrimEnd();

            if (result[i] != string.Empty)
            {
                Console.WriteLine(result[i]);
            }
        }      
    }
}

