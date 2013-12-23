using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarMachines.Machines
{
    using WarMachines.Interfaces;

    public class Tank : Machine, ITank
    {
        private const double InitialHealth = 100;
        private bool defenseMode;
        private double changeAttack = 40;
        private double changeDeffense = -30;


        public Tank(string name, double attackPoints, double defensePoints) : base(name, attackPoints, defensePoints)
        {
            this.HealthPoints = InitialHealth;
            ToggleDefenseMode();
        }

        public bool DefenseMode
        {
            get { return this.defenseMode; }
        }

        public void ToggleDefenseMode()
        {
            changeAttack *= -1;
            changeDeffense *= -1;

            this.attackPoints += changeAttack;
            this.defensePoints += changeDeffense;

            this.defenseMode = !this.defenseMode;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(base.ToString());
            result.AppendLine(" *Defense: " + (defenseMode ? "ON" : "OFF"));

            return result.ToString();

        }
    }
}
