using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TeamProject
{
    class Program
    {
        const int MaxHeight = 70;
        const int MaxWidth = 50;

        const int spaceBetweenEnemies = 40;
        const int enemySpead = 4;

        static void Main(string[] args)
        {
            List<Enemy> enemies = new List<Enemy>(); 
            List<Shot> shots = new List<Shot>();

            Player joker = new Player();
            joker.X = MaxWidth / 2;
            joker.Y = MaxHeight - joker.playerShape.GetLength(0);

            Random rand = new Random();
            
            Console.BufferHeight = Console.WindowHeight = MaxHeight;
            Console.BufferWidth = Console.WindowWidth = MaxWidth;

            int currentSpaceBetwennnemies = 0;
            int currentEnemySpeed = 0;

            while (true)
            {
                currentSpaceBetwennnemies++;
                currentEnemySpeed++;

                if (currentSpaceBetwennnemies % spaceBetweenEnemies == 0)
                {
                    enemies.Add(new Enemy(rand.Next(0, MaxWidth - 19), 1)); //add new enemy on random position(19 is magic number so far)
                    currentSpaceBetwennnemies = 0;
                }
                if (currentEnemySpeed % enemySpead == 0)
                {
                    MoveEnemies(enemies);
                    currentEnemySpeed = 0;
                }

                MoveShot(shots);

                //TODO:
                    //HandleCollisions
                      //if enemy is shot kill it
                      //if enemy hits player kill it

                DrawEnemy(enemies);
                DrawPlayer(joker);
                DrawShot(shots);

                if (Console.KeyAvailable) // read keys  - movement and shooting
                {
                    ConsoleKeyInfo pressedKey = Console.ReadKey(true);

                    while (Console.KeyAvailable)
                    {
                        Console.ReadKey(true);
                    }
                    if (pressedKey.Key == ConsoleKey.LeftArrow || pressedKey.Key == ConsoleKey.RightArrow)
                    {
                        joker.Move(pressedKey);
                    }
                    if (pressedKey.Key == ConsoleKey.Spacebar)
                    {
                        shots.Add(new Shot(joker.X + 3, MaxHeight - 12));
                    }                    
                }

                Thread.Sleep(100);

                Console.Clear();
            }
        }
        static void MoveEnemies(List<Enemy> enemies)
        {
            foreach (Enemy enemy in enemies)
            {
                enemy.Move();
            }
        }

        //static void RemoveEnemy(List<Bat> enemies) //collision detection not implemented
        //{
        //    foreach (Bat enemy in enemies)
        //    {
        //        if (enemy.Y >= MaxHeight)
        //        {
        //            enemies.Remove(enemy);
        //        }
        //    }
        //}
        static void MoveShot(List<Shot> shots)
        {
            foreach (Shot shot in shots)
            {
                shot.Move();
            }
        }

        //static void RemoveShot(List<Shot> shots) // collision detection not implemented
        //{
        //    foreach (Shot shot in shots)
        //    {
        //        if (shot.Y <= 0)
        //        {
        //            shots.Remove(shot);
        //        }
        //    }
        //}

        // TODO: redo these methods
        static void DrawEnemy(List<Enemy> enemies)
        {
            foreach (Enemy enemy in enemies)
            {
                if (enemy.Y < MaxHeight)
                {
                    Console.SetCursorPosition(enemy.X, enemy.Y);

                    for (int row = 0; row < enemy.enemyShape.GetLength(0); row++)
                    {
                        for (int col = 0; col < enemy.enemyShape.GetLength(1); col++)
                        {
                            Console.Write(enemy.enemyShape[row, col]);
                        }
                        if (enemy.Y + row + 1 == MaxHeight)
                        {
                            break;
                        }
                        Console.SetCursorPosition(enemy.X, enemy.Y + row + 1);
                    }
                }
            }
        }
        static void DrawPlayer(Player joker)
        {
            Console.SetCursorPosition(joker.X, joker.Y);

            for (int row = 0; row < joker.playerShape.GetLength(0); row++)
            {
                for (int col = 0; col < joker.playerShape.GetLength(1); col++)
                {
                    Console.Write(joker.playerShape[row, col]);
                }
                if (joker.Y + row + 1 == MaxHeight)
                {
                    break;
                }
                Console.SetCursorPosition(joker.X, joker.Y + row + 1);
            }
        }

        static void DrawShot(List<Shot> shots)
        {
            foreach (Shot shot in shots)
            {
                if (shot.Y > 0)
                {
                    Console.SetCursorPosition(shot.X, shot.Y);

                    for (int row = 0; row < shot.shotShape.GetLength(0); row++)
                    {
                        for (int col = 0; col < shot.shotShape.GetLength(1); col++)
                        {
                            Console.Write(shot.shotShape[row, col]);
                        }

                        Console.SetCursorPosition(shot.X, shot.Y + row + 1);
                    }
                }
            }
        }
    }
}
