using StructuralPatterns_Decorator.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns_Decorator.Decorators
{
    public class WhippedCreamDecorator : CoffeeDecorator
    {
        public WhippedCreamDecorator(ICoffee coffee) : base(coffee) { }

        public override string GetDescription()
        {
            return base.GetDescription() + ", Whipped Cream";
        }

        public override double GetCost()
        {
            return base.GetCost() + 0.7; // Adding the cost of whipped cream
        }
    }
}
