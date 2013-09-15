using System;
using System.Text;

class CleanCode
{
    static void Main()
    {
        int lines = int.Parse(Console.ReadLine());

        for (int line = 0; line < lines; line++)
        {
            StringBuilder code = new StringBuilder();

            string currentLine = Console.ReadLine();

            int comment = currentLine.IndexOf("//");

            if (comment == -1)
            {
                code.Append(currentLine);
            }
            else if (comment == 0)
            {
                
            }

            Console.WriteLine();

            
        }
    }
}

