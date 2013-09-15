using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject
{
    public class Enemy : PlayFieldObjects
    {
        public string[,] enemyShape = 
            {
                {
                "-", "=", "#", "#", "#", "#", ".", " ", "^", " ", "^", " ", ".", "#", "#", "#", "#", "=", "-"},
                {
                " ", " ", " ", "-", "=", "#", "#", ".", "#", "#", "#", ".", "#", "#", "=", "-", " ", " ", " "},
                {
                " ", " ", " ", " ", " ", " ", " ", "-", "=", "#", "=", "-", " ", " ", " ", " ", " ", " ", " "},               
            };
        public Enemy()
        { }

        public Enemy(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        
        public override void Move()
        {
            this.Y++;
        }


    }
}
