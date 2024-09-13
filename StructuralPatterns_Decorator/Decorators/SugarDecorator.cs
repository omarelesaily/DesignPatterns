﻿using StructuralPatterns_Decorator.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns_Decorator.Decorators
{
    public class SugarDecorator : CoffeeDecorator
    {
        public SugarDecorator(ICoffee coffee) : base(coffee) { }

        public override string GetDescription()
        {
            return base.GetDescription() + ", Sugar";
        }

        public override double GetCost()
        {
            return base.GetCost() + 0.2; // Adding the cost of sugar
        }
    }
}
