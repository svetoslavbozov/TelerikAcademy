using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleJustification
{
    class ConsoleJustification
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int maxLineLength = int.Parse(Console.ReadLine());

            StringBuilder allText = new StringBuilder();
            StringBuilder result = new StringBuilder();

            while (lines > 0)
            {
                allText.AppendLine(Console.ReadLine());
                lines--;
            }

            var queue = new Queue<string>(allText.ToString().Split(new[] { " ", Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries));

            allText.Clear();

            List<string> currentLine = new List<string>();

            int currentLength = 0;
            
            while (0 < queue.Count)
            {
                currentLength += queue.Peek().Length;

                if (currentLength <= maxLineLength)
                {
                    currentLine.Add(queue.Dequeue() + " ");
                    currentLength++;
                }
                else 
                {
                    currentLength = (currentLength - queue.Peek().Length) - 1;

                    if (currentLength <= maxLineLength)
                    {
                        int next = 0;
                        while (currentLength < maxLineLength)
                        {
                            currentLine[next++] += " ";
                            currentLength++;
                            if (next >= currentLine.Count - 1 )
                            {
                                next = 0;
                            }
                        }

                        foreach (var item in currentLine)
                        {
                            allText.Append(item);
                        }

                        result.AppendLine(allText.ToString().TrimEnd());
                        currentLength = 0;
                        allText.Clear();
                        currentLine.Clear();           
                    }
                }
            }
            currentLength--;
            if (currentLength <= maxLineLength)
            {
                int next = 0;
                while (currentLength < maxLineLength)
                {
                    currentLine[next++] += " ";
                    currentLength++;
                    if (next >= currentLine.Count - 1)
                    {
                        next = 0;
                    }
                }
            }
            foreach (var item in currentLine)
            {
                allText.Append(item);
            }

            result.Append(allText.ToString().TrimEnd());

            Console.WriteLine(result);
        }
    }
}
