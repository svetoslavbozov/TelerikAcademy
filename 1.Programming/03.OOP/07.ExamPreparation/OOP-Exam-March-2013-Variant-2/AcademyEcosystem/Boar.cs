using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyEcosystem
{
    class Boar : Animal, ICarnivore, IHerbivore
    {
        private const int BoarSize = 4;
        private const int BoarBiteSize = 2;

        private int biteSize;

        public Boar(string name, Point location)
            : base(name, location, BoarSize)
        {
            this.biteSize = BoarBiteSize;
        }

        public int EatPlant(Plant plant)
        {
            if (plant != null)
            {
                this.Size += 1;
                return plant.GetEatenQuantity(this.biteSize);
            }

            return 0;
        }

        public int TryEatAnimal(Animal animal)
        {
            if (animal == null)
            {
                return 0;
            }

            if (animal is Zombie || animal.Size <= this.Size)
            {
                return animal.GetMeatFromKillQuantity();
            }
            //allways has bitesize 2 ???
            return 0;
        }
    }
}
