using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns_FactoryMethod.SubClasses
{
    internal class OmeletteCheeseSandwich : ISandwich
    {
        public string Name { get; set; } = "Omelette Cheese Sandwich";
        public string MainIngrediant { get; set; } = "Omelette and Cheese";
        public bool IsVegetarian { get; set; } = true;

    }
}
