using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarMachines.Machines
{
    using WarMachines.Interfaces;

    public abstract class Machine : IMachine
    {
        private string name;
        private IPilot pilot;
        private double healthPoints;
        protected double attackPoints;
        protected double defensePoints;
        private IList<string> targets;

        public Machine(string name, double attackPoints, double defensePoints)
        {
            this.Name = name;
            this.attackPoints = attackPoints;
            this.defensePoints = defensePoints;
            this.targets = new List<string>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public IPilot Pilot
        {
            get
            {
                return this.pilot;
            }
            set
            {
                this.pilot = value;
            }
        }

        public double HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                this.healthPoints = value;
            }
        }

        public double AttackPoints
        {
            get { return this.attackPoints; }
        }

        public double DefensePoints
        {
            get { return this.defensePoints; }
        }

        public IList<string> Targets
        {
            get { return this.targets; }
        }

        public void Attack(string target)
        {
            this.targets.Add(target);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine("- " + this.name);
            result.AppendLine(" *Type: " + this.GetType().Name);
            result.AppendLine(" *Health: " + this.healthPoints.ToString());
            result.AppendLine(" *Attack: " + this.attackPoints.ToString()); 
            result.AppendLine(" *Defense: " + this.defensePoints.ToString());
            result.Append(" *Targets: ");

            if (this.targets.Count > 0)
            {
                result.AppendLine(String.Join(", ", this.targets));
            }
            else
            {
                result.AppendLine("None");
            }

            return result.ToString();
        }
    }
}
