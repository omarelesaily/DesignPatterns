using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns_AbstractFactory.SubClasses
{
    internal class ForeignCuisineSandwich : ISandwich
    {
        public string Name { get; set; } = "Caprese Sandwich";
        public string MainIngrediant { get; set; } = "Fresh Mozzarella";
        public bool IsVegetarian { get; set; } = false;
    }
}
