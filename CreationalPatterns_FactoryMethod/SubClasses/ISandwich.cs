using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns_FactoryMethod.SubClasses
{
    public interface ISandwich
    {
        public string Name { get; set; }
        public string MainIngrediant { get; set; }
        public bool IsVegetarian { get; set; }
        public void PrintData()
        {
            string name = Name ?? "Unnamed Sandwich";
            string mainIngrediant = MainIngrediant ?? "Unknown Ingredient";
            string vegetarianStatus = IsVegetarian ? "a" : "not a";

            Console.WriteLine($"i'm a {name}, My Main Ingerdian is {mainIngrediant} and i'm {(vegetarianStatus)} Vegetarian.");
        }
    }
}
