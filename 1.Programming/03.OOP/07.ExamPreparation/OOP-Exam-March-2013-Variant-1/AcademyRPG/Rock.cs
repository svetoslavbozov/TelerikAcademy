using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    public class Rock : StaticObject, IResource
    {
        private ResourceType type = ResourceType.Stone;

        public Rock(Point position, int owner = 0)
            : base(position, owner)
        {
        }

        public Rock(Point position, int owner, int hitPoints)
            : this(position, owner)
        {
            this.HitPoints = hitPoints;
        }

        public ResourceType Type
        {
            get { return this.type; }
        }

        public int Quantity
        {
            get { return (this.HitPoints / 2); }
        }
    }
}
