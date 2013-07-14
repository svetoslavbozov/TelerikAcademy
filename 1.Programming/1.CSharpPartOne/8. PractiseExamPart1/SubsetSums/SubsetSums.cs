using System;

class SubsetSums
{
    static void Main()
    {

        long S = long.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());

        long[] numbers = new long[N + 1];

        for (int i = 0; i < N; i++)
        {
            numbers[i] = long.Parse(Console.ReadLine());
        }

        int answer = 0;
        int subsets = (int)Math.Pow(2, N) - 1;

        for (int i = 1; i <= subsets; i++)
        {
            long currentSum = 0;

            for (int j = 1; j <= N; j++)
            {
                if (((i >> (j - 1)) & 1) == 1)
                {
                    currentSum += numbers[j - 1];
                }
            }
            if (currentSum == S)
            {
                answer++;
            }
        }

        Console.WriteLine(answer);
    }
}
    


