using System;
using System.Numerics;

class SecretsofNumbers
{
    static void Main()
    {
        string number = Console.ReadLine().Replace("-", "").Replace(".", "");
        int[] digits = new int[number.Length];

        for (int index = 0; index < number.Length; index++)
        {
            digits[index] = Convert.ToInt32(number[index] - '0');
        }

        Array.Reverse(digits);

        int specialSum = 0;

        for (int index = 1; index <= digits.Length; index++)
        {
            if (index % 2 != 0)
            {
                specialSum += digits[index - 1] * (int)Math.Pow(index, 2);
            }
            else
            {
                specialSum += (int)Math.Pow(digits[index - 1], 2) * index;
            }
        }

        int remainder = specialSum % 26;
        int secretSequence = specialSum % 10;

        Console.WriteLine(specialSum);
        if (secretSequence == 0)
        {
            Console.WriteLine("{0} has no secret alpha-sequence", number);
        }
        else
        {
            for (int index = 1; index <= secretSequence; index++)
            {
                int nextletter = (remainder + index) % 26;

                if (nextletter == 0)
                {
                    nextletter = 26;
                }

                char letter = Convert.ToChar(nextletter + 64);
                Console.Write(letter);
            }
            Console.WriteLine();
        }
    }
}

