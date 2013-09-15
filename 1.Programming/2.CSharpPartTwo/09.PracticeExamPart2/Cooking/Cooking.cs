using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cooking
{
    class Ingridiens
    {
        public double Quantity { get; set; }
        public string Unit { get; set; }
        public string Name { get; set; }

        public Ingridiens(double quantity, string unit, string name)
        {
            Quantity = quantity;
            Unit = unit;
            Name = name;
        }
    }
    class Cooking
    {
        static void Main(string[] args)
        {
            List<Ingridiens> recipe = new List<Ingridiens>();
            List<Ingridiens> used = new List<Ingridiens>();

            int recipeLines = int.Parse(Console.ReadLine());

            while (recipeLines > 0)
            {
                string[] current = Console.ReadLine().Split(new[] { ":" }, StringSplitOptions.RemoveEmptyEntries);
                recipe.Add(new Ingridiens(double.Parse(current[0]), current[1], current[2]));
                recipeLines--;
            }

            int usedLines = int.Parse(Console.ReadLine());

            while (usedLines > 0)
            {
                string[] current = Console.ReadLine().Split(new[] { ":" }, StringSplitOptions.RemoveEmptyEntries);
                used.Add(new Ingridiens(double.Parse(current[0]), current[1], current[2]));
                usedLines--;
            }

            for (int i = 0; i < recipe.Count; i++)
            {
                for (int j = 0; j < used.Count; j++)
                {
                    if (string.Equals(recipe[i].Name, used[j].Name, StringComparison.InvariantCultureIgnoreCase))
                    {
                        if (!string.Equals(recipe[i].Unit, used[j].Unit))
                        {
                            used[j].Quantity = Convert(recipe[i].Quantity, used[j].Quantity, recipe[i].Unit, used[j].Unit);
                        }
                        
                        recipe[i].Quantity -= used[j].Quantity;
                                              
                    }
                }
            }

            for (int i = 0; i < recipe.Count; i++)
            {
                for (int j = i + 1; j < recipe.Count; j++)
                {
                    if (j != i && string.Equals(recipe[i].Name, recipe[j].Name, StringComparison.InvariantCultureIgnoreCase))
                    {
                        if (!string.Equals(recipe[i].Unit, recipe[j].Unit))
                        {
                            recipe[j].Quantity = Convert(recipe[i].Quantity, recipe[j].Quantity, recipe[i].Unit, recipe[j].Unit);
                        }
                        
                        recipe[i].Quantity += recipe[j].Quantity;
                        recipe[j].Quantity = -1;
                    }
                }
            }

            foreach (var item in recipe)
            {
                if (item.Quantity > 0)
                {
                    Console.WriteLine("{0:0.00}:{1}:{2}", Math.Round(item.Quantity,2), item.Unit, item.Name);
                }
            }
        }
        static double Convert(double firstQuantity, double secondQuantity, string firstUnit, string secondUnit)
        {
            if ((firstUnit == "tbsps" || firstUnit == "tablespoons") && (secondUnit == "tsps" || secondUnit == "teaspoons"))
            {
                return secondQuantity / 3;
            }
            else if ((firstUnit == "tsps" || firstUnit == "teaspoons") && (secondUnit == "tbsps" || secondUnit == "tablespoons"))
            {
                return secondQuantity * 3;
            }
            else if ((firstUnit == "ls" || firstUnit == "liters ") && (secondUnit == "mls" || secondUnit == "milliliters "))
            {
                return secondQuantity / 1000;
            }
            else if ((firstUnit == "mls" || firstUnit == "milliliters ") && (secondUnit == "ls" || secondUnit == "liters "))
            {
                return secondQuantity * 1000;
            }
            else if ((firstUnit == "fl ozs" || firstUnit == "fluid ounces ") && (secondUnit == "cups" || secondUnit == "cups"))
            {
                return secondQuantity / 8;
            }
            else if ((firstUnit == "cups" || firstUnit == "cups") && (secondUnit == "fl ozs" || secondUnit == "fluid ounces "))
            {
                return secondQuantity * 8;
            }
            else if ((firstUnit == "teaspoons" || firstUnit == "teaspoons") && (secondUnit == "mls" || secondUnit == "milliliters"))
            {
                return secondQuantity / 5;
            }
            else if ((firstUnit == "mls" || firstUnit == "milliliters") && (secondUnit == "teaspoons" || secondUnit == "teaspoons"))
            {
                return secondQuantity * 5;
            }
            else if ((firstUnit == "gals" || firstUnit == "gallons") && (secondUnit == "quarts" || secondUnit == "quarts"))
            {
                return secondQuantity / 4;
            }
            else if ((firstUnit == "quarts" || firstUnit == "quarts") && (secondUnit == "gals" || secondUnit == "gallons"))
            {
                return secondQuantity * 4;
            }
            else if ((firstUnit == "pts" || firstUnit == "pints") && (secondUnit == "cups" || secondUnit == "cups"))
            {
                return secondQuantity / 2;
            }
            else if ((firstUnit == "cups" || firstUnit == "cups") && (secondUnit == "pts" || secondUnit == "pints"))
            {
                return secondQuantity * 2;
            }
            else if ((firstUnit == "qts" || firstUnit == "quarts") && (secondUnit == "pts" || secondUnit == "pints"))
            {
                return secondQuantity / 2;
            }
            else if ((firstUnit == "pts" || firstUnit == "pints") && (secondUnit == "qts" || secondUnit == "quarts"))
            {
                return secondQuantity * 2;
            }
            else if ((firstUnit == "cups" || firstUnit == "cups") && (secondUnit == "tsps" || secondUnit == "teaspoons"))
            {
                return secondQuantity / 48;
            }
            else if ((firstUnit == "tsps" || firstUnit == "teaspoons") && (secondUnit == "cups" || secondUnit == "cups"))
            {
                return secondQuantity * 48;
            }
            return 0;
        }
    }
}
