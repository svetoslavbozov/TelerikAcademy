using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarMachines.Machines
{
    using WarMachines.Interfaces;

    public class Pilot : IPilot
    {
        private string name;
        private IList<IMachine> machines = new List<IMachine>();

        public Pilot(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return this.name; }
        }

        public void AddMachine(IMachine machine)
        {
            this.machines.Add(machine);
        }

        public string Report()
        {
            StringBuilder result = new StringBuilder();

            result.Append(this.name + " - ");

            if (this.machines.Count == 0)
            {
                result.Append("no machines");
            }
            else if (this.machines.Count == 1)
            {
                result.AppendLine("1 machine");
                result.Append(machines[0].ToString());
            }
            else
            {
                machines.OrderBy(x => x.HealthPoints).ThenBy(x => x.Name);

                result.AppendLine(this.machines.Count + " machines");

                foreach (var machine in machines)
                {
                    result.Append(machine.ToString());
                }
            }

            return result.ToString();
        }
    }
}
