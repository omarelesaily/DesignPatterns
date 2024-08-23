using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns_AbstractFactory.SubClasses
{
    internal class ArabianCuisineSandwich : ISandwich
    {
        public string Name { get; set; } = "Flaffl and Fol";
        public string MainIngrediant { get; set; } = "Beans";
        public bool IsVegetarian { get; set; } = true;
    }
}
