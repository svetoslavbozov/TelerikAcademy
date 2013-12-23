using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyEcosystem
{
    public class Wolf : Animal, ICarnivore
    {
        private const int WolfSize = 4;

        public Wolf(string name, Point location)
            : base(name, location, WolfSize)
        {
                
        }

        public int TryEatAnimal(Animal animal)
        {
            if (animal == null)
            {
                return 0;
            }

            if (animal is Zombie || animal.Size <= WolfSize || animal.State == AnimalState.Sleeping)
            {
                return animal.GetMeatFromKillQuantity();
            }

            return 0;            
        }
    }
}
