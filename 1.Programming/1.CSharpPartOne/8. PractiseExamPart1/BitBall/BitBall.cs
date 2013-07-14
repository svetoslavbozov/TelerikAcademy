using System;

class BitBall
{
    static void Main()
    {
        byte[] top = new byte[8];
        byte[] bottom = new byte[8];        

        int topScore = 0;
        int bottomScore = 0;

        //read top
        for (int i = 0; i < 8; i++)
        {
            top[i] = byte.Parse(Console.ReadLine());
        }
        //read bottom
        for (int i = 0; i < 8; i++)
        {
            bottom[i] = byte.Parse(Console.ReadLine());
        }

        //eliminate duplicate players
        for (int i = 0; i < 8; i++)
        {
            for (int bit = 0; bit < 8; bit++)
            {
                if (((top[i] >> bit) & 1) == 1 && ((bottom[i] >> bit) & 1) == 1)
                {
                    top[i] = Convert.ToByte(top[i] ^ (1 << bit));
                    bottom[i] = Convert.ToByte(bottom[i] ^ (1 << bit));
                }
            }
        }

        //top turn
        bool[] scored = new bool[8];

        for (int index = 0; index < 8; index++)
        {
            for (int bits = 0; bits < 8; bits++)
            {
                if (((top[index] >> bits) & 1) == 1 && !scored[bits])
                {
                    for (int check = index; check < 8; check++)
                    {
                        if (((bottom[check] >> bits) & 1) == 1 )
                        {
                            break;
                        }
                        else if (check == 7)
                        {
                            topScore++;
                            scored[bits] = true;
                        }
                    }
                }
            }
        }

        //bottom turn
        scored = new bool[8];

        for (int index = 7; index >= 0 ; index--)
        {
            for (int bits = 0; bits < 8; bits++)
            {
                if (((bottom[index] >> bits) & 1) == 1 && !scored[bits])
                {
                    for (int check = index; check >= 0; check--)
                    {
                        if (((top[check] >> bits) & 1) == 1)
                        {
                            break;
                        }
                        else if (check == 0)
                        {
                            bottomScore++;
                            scored[bits] = true;
                        }
                    }
                }
            }
        }

        Console.WriteLine("{0}:{1}", topScore, bottomScore);
    }
}

