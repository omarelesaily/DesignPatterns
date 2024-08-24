using CreationalPatterns_Builder.SubCLasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns_Builder.Builder
{
    public interface ISandwichBuilder
    {
        ISandwichBuilder SetBread(string bread);
        ISandwichBuilder SetSpread(string spread);
        ISandwichBuilder SetFillings(string fillings);
        Sandwich Build();
    }
}
