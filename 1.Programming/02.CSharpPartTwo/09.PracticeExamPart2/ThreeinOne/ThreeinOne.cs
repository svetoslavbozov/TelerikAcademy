using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeinOne
{
    class ThreeinOne
    {
        static void Main(string[] args)
        {
            short[] points = Console.ReadLine().Split(new[] { "," }, StringSplitOptions.None).Select(x => Convert.ToInt16(x)).ToArray();
            short[] cakes = Console.ReadLine().Split(new[] { "," }, StringSplitOptions.None).Select(x => Convert.ToInt16(x)).ToArray();
            short friends = short.Parse(Console.ReadLine());
            int[] coins = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.None).Select(x => Convert.ToInt32(x)).ToArray();


            Console.WriteLine(CardsWinner(points));
            CalculateBites(cakes, friends);
            CalculateCoins(coins);
            
        }
        private static int CardsWinner(short[] points)
        {
            int bestPoints = -1;
            int bestPlayer = -1;

            for (int i = 0; i < points.Length; i++)
            {
                if (points[i] > 21)
                {
                    continue;
                }
                if (points[i] > bestPoints)
                {
                    bestPoints = points[i];
                    bestPlayer = i;
                }
                else if (points[i] == bestPoints)
                {
                    bestPlayer = -1;
                }
            }
            return bestPlayer;
        }
        static void CalculateBites(short[] cakes, short friends)
        {
            int bites = 0;
            cakes = cakes.OrderByDescending(c => c).ToArray();

            for (int i = 0; i < cakes.Length; i++)
			{
			    if (i % (friends + 1) == 0)
	            {
		            bites += cakes[i];
	            }
			}

            Console.WriteLine(bites);
        }
        static void CalculateCoins(int[] coins)
        {
            int result = 0;

            int[] coin1 = new int[] { coins[0], coins[1], coins[2] };
            int[] coin2 = new int[] { coins[3], coins[4], coins[5] };

            if (coin1[2] < coin2[2])
            {
                while (coin1[2] < coin2[2])
                {
                    coin1[2] += 9;
                    coin1[1] -= 1;
                    result++;
                }
            }
            if (coin1[0] < coin2[0])
            {
                while (coin1[0] < coin2[0])
                {
                    coin1[1] -= 11;
                    coin1[0] += 1;
                    result++;
                }
            }
            if (coin1[1] < coin2[1])
            {
                if (coin1[0] > coin2[0])
                {
                while (coin1[0] > coin2[0] && coin1[1] < coin2[1])
                {
                    coin1[1] += 9;
                    coin1[0] -= 1;
                    result++;
                }
                }
                if (coin1[2] > coin2[2] + 11)
                {
                    while (coin1[2] > (coin2[2] + 11) && coin1[1] < coin2[1])
                    {
                        coin1[2] -= 11;
                        coin1[1] += 1;
                        result++;
                    }
                }
                while (coin1[0] < coin2[0])
                {
                    coin1[0] += 9;
                    coin1[1] -= 1;
                    result++;
                }
            }
            if (coin1[0] >= coin2[0] && coin1[1] >= coin2[1] && coin1[2] >= coin2[2])
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(-1);
            }             
        }
    }
}
