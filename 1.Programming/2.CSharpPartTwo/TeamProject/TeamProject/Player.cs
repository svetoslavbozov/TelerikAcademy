using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject
{
    public class Player : PlayFieldObjects
    {
        private int hitPoints; // not implemented

        public string[,] playerShape = 
            {
                {" ", "_", " ", " ", " ", "/", "/", "(", "`", ")", "_", " ", " "},
                {"/", "/", @"`", @"\", "/", " ", "|", @"\", " ", "0", "`", @"\", @"\"},
                {"|", "|", "-", ".", @"\", "_", "|", "_", "/", ".", "-", "|", "|"},
                {")", "/", " ", "|", "_", "_", "_", "_", "_", "|", " ", @"\", "("},
                {"0", " ", " ", "#", " ", @"\", " ", "/", " ", "#", " ", " ", "0"},
                {" ", " ", "(", "|", " ", " ", "^", " ", " ", "|", ")", " ", " "},   
                {" ", " ", " ", "|", " ", @"\", "_", "/", " ", "|", " ", " ", " "},
                {" ", " ", " ", " ", @"\", "_", "_", "_", "/", " ", " ", " ", " "}
            };

        public Player()
        { }

        public Player(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(ConsoleKeyInfo key)
        {
            if (key.Key == ConsoleKey.LeftArrow)
            {
                if (this.X - 1 > 0)
                {
                    this.X--;
                }
            }

            if (key.Key == ConsoleKey.RightArrow)
            {
                if (this.X + 1 < Console.BufferWidth - 1 - playerShape.GetLength(0)*3/2)
                {
                    this.X++;
                }
            }
        }
    }
}
