using CreationalPatterns_FactoryMethod.SubClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns_FactoryMethod.FactoryClass
{
    internal interface ISandwichFactory
    {
        public ISandwich CreateSandwich();

    }
    public class TunaSandwichFactory : ISandwichFactory
    {
        public ISandwich CreateSandwich()
        {
            return new TunaSandwich();
        }
    }
    public class OmeletteCheeseSandwichFactory : ISandwichFactory
    {
        public ISandwich CreateSandwich()
        {
            return new OmeletteCheeseSandwich();
        }
    }
}
