using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyEcosystem
{
    public class Lion : Animal, ICarnivore
    {
        private const int LionSize = 6;

        public Lion(string name, Point location) : base(name, location, LionSize)
        {

        }

        public int TryEatAnimal(Animal animal)
        {
            if (animal == null)
            {
                return 0;
            }

            if (animal is Zombie || animal.Size <= this.Size * 2)
            {
                this.Size += 1;
                return animal.GetMeatFromKillQuantity();
            }

            return 0;
        }
    }
}
