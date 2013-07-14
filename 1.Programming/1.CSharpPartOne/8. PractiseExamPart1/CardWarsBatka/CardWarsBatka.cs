using System;
using System.Numerics;

class CardWarsBatka
{
    static void Main()
    {
        int gamesCount = int.Parse(Console.ReadLine());

        BigInteger playerOneFinalScore = 0;
        BigInteger playerTwoFinalScore = 0;

        int firstWins = 0;
        int secondWins = 0;

        bool gameWonWIthX = false;

        for (int games = 0; games < gamesCount && !gameWonWIthX; games++)
        {
            int playeOneCurrentScore = 0;
            int playerTwoCurrentScore = 0;
            bool playerOneWins = false;
            bool playerTwoWins = false;

            for (int firstPlayerCards = 0; firstPlayerCards < 3; firstPlayerCards++)
            {
                string currentCard = Console.ReadLine();

                switch (currentCard)
                {
                    case "A":
                        playeOneCurrentScore += 1; break;
                    case "J":
                        playeOneCurrentScore += 11; break;
                    case "Q":
                        playeOneCurrentScore += 12; break;
                    case "K":
                        playeOneCurrentScore += 13; break;
                    case "Z":
                        playerOneFinalScore *= 2; break;
                    case "Y":
                        playerOneFinalScore -= 200; break;
                    case "X":
                        playerOneWins = true; break;
                    case "2":
                        playeOneCurrentScore += 10; break;
                    case "3":
                        playeOneCurrentScore += 9; break;
                    case "4":
                        playeOneCurrentScore += 8; break;
                    case "5":
                        playeOneCurrentScore += 7; break;
                    case "6":
                        playeOneCurrentScore += 6; break;
                    case "7":
                        playeOneCurrentScore += 5; break;
                    case "8":
                        playeOneCurrentScore += 4; break;
                    case "9":
                        playeOneCurrentScore += 3; break;
                    case "10":
                        playeOneCurrentScore += 2; break;
                }
            }

            for (int secondPlayerCards = 0; secondPlayerCards < 3; secondPlayerCards++)
            {
                string currentCard = Console.ReadLine();

                switch (currentCard)
                {
                    case "A":
                        playerTwoCurrentScore += 1; break;
                    case "J":
                        playerTwoCurrentScore += 11; break;
                    case "Q":
                        playerTwoCurrentScore += 12; break;
                    case "K":
                        playerTwoCurrentScore += 13; break;
                    case "Z":
                        playerTwoFinalScore *= 2; break;
                    case "Y":
                        playerTwoFinalScore -= 200; break;
                    case "X":
                        playerTwoWins = true; break;
                    case "2":
                        playerTwoCurrentScore += 10; break;
                    case "3":
                        playerTwoCurrentScore += 9; break;
                    case "4":
                        playerTwoCurrentScore += 8; break;
                    case "5":
                        playerTwoCurrentScore += 7; break;
                    case "6":
                        playerTwoCurrentScore += 6; break;
                    case "7":
                        playerTwoCurrentScore += 5; break;
                    case "8":
                        playerTwoCurrentScore += 4; break;
                    case "9":
                        playerTwoCurrentScore += 3; break;
                    case "10":
                        playerTwoCurrentScore += 2; break;
                }
            }

            if (playerOneWins && playerTwoWins)
            {
                playerOneFinalScore += 50;
                playerTwoFinalScore += 50;
            }
            else if (playerOneWins && !playerTwoWins)
            {
                Console.WriteLine("X card drawn! Player one wins the match!");
                gameWonWIthX = true;
            }
            else if (!playerOneWins && playerTwoWins)
            {
                Console.WriteLine("X card drawn! Player two wins the match!");
                gameWonWIthX = true;
            }

            if (playeOneCurrentScore > playerTwoCurrentScore)
            {
                firstWins += 1;
                playerOneFinalScore += playeOneCurrentScore;
            }
            else if (playeOneCurrentScore < playerTwoCurrentScore)
            {
                secondWins += 1;
                playerTwoFinalScore += playerTwoCurrentScore;
            }
        }
        

        if (!gameWonWIthX)
        {
            if (playerOneFinalScore > playerTwoFinalScore)
            {
                Console.WriteLine("First player wins!");
                Console.WriteLine("Score: {0}", playerOneFinalScore);
                Console.WriteLine("Games won: {0}", firstWins);
            }
            else if (playerOneFinalScore < playerTwoFinalScore)
            {
                Console.WriteLine("Second player wins!");
                Console.WriteLine("Score: {0}", playerTwoFinalScore);
                Console.WriteLine("Games won: {0}", secondWins);
            }
            else if (playerOneFinalScore == playerTwoFinalScore)
            {
                Console.WriteLine("It's a tie!");
                Console.WriteLine("Score: {0}", playerOneFinalScore);
            }
        }
        //Console.WriteLine();
    }
}