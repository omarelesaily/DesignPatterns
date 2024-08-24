using CreationalPatterns_Prototype.ICloneable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns_Prototype.SubClasses
{
    public class Sandwich : ICloneableSandwich
    {
        public Guid ID { get; set; } = new Guid();
        public string Name { get; set; }
        public string MainIngrediant { get; set; }
        public bool IsVegetarian { get; set; }
        public SandwichComponents Components { get; set; }

        //shallow clone : refernce changes will change in all clones and original objects,
        //be aware that some types are immutable that even if they are a reference type and
        //you changed them they will not change any of the clones or the original object
        //Example : string , the original will not be affected and changed as the clone changes
        //Example : class the contian string property , original will be changed and affected as the clone changes
        public ICloneableSandwich Clone()
        {
            return (ICloneableSandwich)this.MemberwiseClone();
        }
    }
    public class SandwichComponents
    {
        public string Bread { get; set; }
        public string Spread { get; set; }
        public string Fillings { get; set; }
    }
}
