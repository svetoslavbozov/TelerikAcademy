using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagesinaBottle
{
    class States
    {
        public string Text { get; set; }
        public string CodeLeft { get; set; }
    }
    class MessagesinaBottle
    {
        static void Main(string[] args)
        {
            string code = Console.ReadLine();
            string cipher = Console.ReadLine();

            Dictionary<string, char> cipherCodes = new Dictionary<string, char>();

            StringBuilder digit = new StringBuilder();
            char letter;

            //fill dictionary
            for (int i = 0; i < cipher.Length; i++)
            {
                letter = cipher[i++]; //take letter go to next index

                while (i < cipher.Length && char.IsDigit(cipher[i]))
                {
                    digit.Append(cipher[i++]);
                }

                cipherCodes.Add(digit.ToString(), letter);
                digit.Clear();
                i--;
            }

            List<States> allStates = new List<States>();
            List<string> result = new List<string>();

            allStates.Add(new States{ Text = "", CodeLeft = code });
            int index = -1;

            while (index < allStates.Count - 1)
            {
                index++;

                foreach (var item in cipherCodes)
                {
                    if (allStates[index].CodeLeft.StartsWith(item.Key))
                    {
                        States currentState = new States();
                        currentState.Text = allStates[index].Text + item.Value;
                        currentState.CodeLeft = allStates[index].CodeLeft.Remove(0, item.Key.Length);

                        if (currentState.CodeLeft == "")
                        {
                            result.Add(currentState.Text);
                        }
                        else
                        {
                            allStates.Add(currentState);                            
                        }
                    }
                }
                
            }

            result.Sort();

            Console.WriteLine(result.Count);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
