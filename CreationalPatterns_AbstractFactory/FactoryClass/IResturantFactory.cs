using CreationalPatterns_AbstractFactory.SubClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns_AbstractFactory.FactoryClass
{
    public interface IResturantFactory
    {
        ISandwich CreateSandwich();
        IMainDish CreateDish();
    }

}
