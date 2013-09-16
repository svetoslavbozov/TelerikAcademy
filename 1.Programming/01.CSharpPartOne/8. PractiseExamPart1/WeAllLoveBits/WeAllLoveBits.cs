using System;

class WeAllLoveBits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());

            string number = Convert.ToString(numbers[i], 2);
            string inverseString = null;

            foreach (char item in number)
            {
                if (item == '1')
                {
                    inverseString += 0;
                }
                else if (item == '0')
                {
                    inverseString += 1;                    
                }                
            }
            
            int inverse = Convert.ToInt32(inverseString, 2);

            char[] binary = Convert.ToString(numbers[i], 2).ToCharArray();
            Array.Reverse(binary);

            int reverse = Convert.ToInt32(new string(binary), 2);

            numbers[i] = ((numbers[i] ^ inverse) & reverse);
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}

