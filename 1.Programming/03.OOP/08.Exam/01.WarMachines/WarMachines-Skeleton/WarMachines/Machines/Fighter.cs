using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarMachines.Machines
{
    using WarMachines.Interfaces;

    class Fighter : Machine, IFighter
    {
        private const double InitialHealthPoints = 200;

        private bool stealthMode;

        public Fighter(string name, double attackPoints, double defensePoints, bool stealthMode)
            : base(name, attackPoints, defensePoints)
        {
            this.stealthMode = stealthMode;
            this.HealthPoints = InitialHealthPoints;
        }
        public bool StealthMode
        {
            get { return this.stealthMode; }
        }

        public void ToggleStealthMode()
        {
            this.stealthMode = !this.stealthMode;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(base.ToString());
            result.Append(" *Stealth: " + (stealthMode ? "ON" : "OFF"));

            return result.ToString();

        }
    }
}
