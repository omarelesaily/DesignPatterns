using CreationalPatterns_Builder.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns_Builder.SubCLasses
{
    public class Resturant
    {
        public Sandwich BuildFlaflSandwich(ISandwichBuilder sandwichBuilder)
        { 
            return sandwichBuilder
                .SetBread("Local Egyption bread")
                .SetSpread("Tahene")
                .SetFillings("Flafl and salad")
                .Build();
        }
        public Sandwich BuildChichenWrapSandwich(ISandwichBuilder sandwichBuilder)
        {
            return sandwichBuilder
                .SetBread("Tortilla Wrap")
                .SetSpread("Caesar Dressing")
                .SetFillings("Grilled Chicken Breast")
                .Build();
        }
    }
}
