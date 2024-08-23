using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns_AbstractFactory.SubClasses
{
    public interface IMainDish
    {
        string Name { get; }
        string Description { get; }
        public void PrintDate()
        {
            string name = Name ?? "Unnamed Dish";
            string description = Description ?? "Not Decription Mentioned";
            Console.WriteLine($"the name of the Dish is {name} and the what we can say about this dish is : {description}");
        }
    }
}
