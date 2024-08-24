using CreationalPatterns_Builder.SubCLasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns_Builder.Builder
{
    public class SandwichBuilder : ISandwichBuilder
    {
        private Sandwich _sandwich=new Sandwich();
        public Sandwich Build()
        {
            return _sandwich;
        }

        public ISandwichBuilder SetBread(string bread)
        {
            _sandwich.Bread= bread;
            return this;
        }

        public ISandwichBuilder SetFillings(string fillings)
        {
            _sandwich.Fillings= fillings;
            return this;
        }

        public ISandwichBuilder SetSpread(string spread)
        {
            _sandwich.Spread= spread;
            return this;
        }
    }
}
