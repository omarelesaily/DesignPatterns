using CreationalPatterns_AbstractFactory.SubClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns_AbstractFactory.FactoryClass
{
    public class ForeignResturant : IResturantFactory
    {
        public IMainDish CreateDish()
        {
            return new ForeignCuisineDish();
        }

        public ISandwich CreateSandwich()
        {
            return new ForeignCuisineSandwich();
        }
    }
}
