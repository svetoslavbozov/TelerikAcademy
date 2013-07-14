using System;

class MissCat2011
{
    static void Main()
    {
        int judgesCount = int.Parse(Console.ReadLine());
        int[] cats = new int[11];

        while (judgesCount > 0)
        {
            int vote = int.Parse(Console.ReadLine());

            cats[vote] += 1;

            judgesCount--;
        }

        int catsVotes = cats[0];
        int indexOfCatWinner = 0;

        for (int i = 0; i < 11; i++)
        {
            if (cats[i] > catsVotes)
            {
                indexOfCatWinner = i;
                catsVotes = cats[i];
            }
        }

        Console.WriteLine(indexOfCatWinner);
    }
}

