using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace PHPVariables
{
    class PHPVariables
    {
        static void Main(string[] args)
        {
            if (File.Exists("input.txt"))
            {
                Console.SetIn(new StreamReader("input.txt"));
            }

            StringBuilder code = new StringBuilder();

            string line = Console.ReadLine();

            while (line != "?>")
            {
                code.AppendLine(line);
                line = Console.ReadLine();
            }

            string all = code.ToString();
            code.Clear();

            for (int i = 0; i < all.Length; i++)
            {
                if (!char.IsLetter(all[i]))
                {
                    if (all[i] == '"')
                    {
                        while (all[i] != ';' && all[i - 1] != '\\')
                        {
                            code.Append(all[i++]);
                        }
                    }
                    if (all[i] == '\'')
                    {
                        while (all[i] != ';' && all[i - 1] != '\\')
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
                    else if (all[i] == '#')
                    {
                        while (all[i] != '\r')
                        {
                            i++;
                        }
                    }
                    else if (all[i] == '/' && all[i + 1] == '*')
                    {
                        i = all.IndexOf("*/", i) + 1;
                        continue;
                    }
                }
                code.Append(all[i]);

            }

            List<string> final = new List<string>();

            foreach (Match item in Regex.Matches(code.ToString(), @"[^\\]\$(\w+\b)"))
            {
                final.Add(item.Groups[1].Value);
            }
            foreach (Match item in Regex.Matches(code.ToString(), @"\\\\\$(\w+\b)"))
            {
                final.Add(item.Groups[1].Value);                
            }

            final = final.Distinct().ToList();

            final.Sort(StringComparer.Ordinal);

            Console.WriteLine(final.Count);

            foreach (var item in final)
            {
                Console.WriteLine(item.Trim());
            }
        }
    }
}
