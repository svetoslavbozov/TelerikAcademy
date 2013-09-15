using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject
{
    class Shot : PlayFieldObjects
    {

        public string[,] shotShape = 
        { 
            { " ", " ", "/",@"\", " ", " "},
            { " ", " ", "|", "|", " ", " "},
            { " ", " ", "|", "|", " ", " "},
            { "[", "=", "=", "=", "=", "]"},
            { " ", " ", "[", "]", " ", " "}
        };


        public Shot()
        { }

        public Shot(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public override void Move()
        {
            this.Y--;
        }
    }
}
