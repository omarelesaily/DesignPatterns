using System.Net;
using System;
using CreationalPatterns_Prototype.SubClasses;

class Program
{
    static void Main(string[] args)
    {
        Sandwich sandwich1 = new Sandwich { ID=Guid.NewGuid(),Name = "Chicken Wrap", MainIngrediant = "Chicken", IsVegetarian = false,Components=new SandwichComponents(){ Bread = "Tortilla Wrap", Fillings = "Grilled Chicken Breast", Spread = "Caesar Dressing" } };
        Sandwich sandwich2 = (Sandwich)sandwich1.Clone();

        // Modifying the copied object's reference type field
        sandwich2.MainIngrediant= "Meat";
        sandwich2.ID = new Guid();
        sandwich2.Components.Fillings = "Meat";

        Console.WriteLine(sandwich1.MainIngrediant); // Output: Chicken, referance but immutable (meaning: can not be changed so a new oject is created with cloning)
        Console.WriteLine(sandwich2.MainIngrediant); // Output: Meat

        Console.WriteLine();

        Console.WriteLine(sandwich1.ID);// Different 
        Console.WriteLine(sandwich2.ID);// Different 00000000-0000-0000-0000-000000000000

        Console.WriteLine();

        Console.WriteLine(sandwich1.Components.Fillings);//OutPut : Meat
        Console.WriteLine(sandwich2.Components.Fillings);//OutPut : Meat
    }

}