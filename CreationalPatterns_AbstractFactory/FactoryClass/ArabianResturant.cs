using CreationalPatterns_AbstractFactory.SubClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns_AbstractFactory.FactoryClass
{
    public class ArabianResturant : IResturantFactory
    {
        public IMainDish CreateDish()
        {
            return new ArabianCuisineDish();
        }

        public ISandwich CreateSandwich()
        {
            return new ArabianCuisineSandwich();
        }
    }
}
