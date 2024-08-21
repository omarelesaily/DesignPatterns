using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns_FactoryMethod.SubClasses
{
    internal class TunaSandwich : ISandwich
    {
        public string Name { get; set; } = "Tuna Sandwich";
        public string MainIngrediant { get; set; } = "Tuna";
        public bool IsVegetarian { get; set; } = false;
    }
}
