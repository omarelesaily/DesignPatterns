using CreationalPatterns_FactoryMethod.FactoryClass;
using CreationalPatterns_FactoryMethod.SubClasses;

class Program
{
    static void Main(string[] args)
    {
        ISandwichFactory tunaSandwichFactory = new TunaSandwichFactory();
        ISandwich tunaSandwich = tunaSandwichFactory.CreateSandwich();
        tunaSandwich.PrintData(); // Output: i'm a Tuna Sandwich, My Main Ingerdian is Tuna and i'm not a Vegetarian.

        ISandwichFactory omeletteCheeseSandwichFactory = new OmeletteCheeseSandwichFactory();
        ISandwich omeletteCheeseSandwich = omeletteCheeseSandwichFactory.CreateSandwich();
        omeletteCheeseSandwich.PrintData(); // Output: i'm a Omelette Cheese Sandwich, My Main Ingerdian is Omelette and Cheese and i'm a Vegetarian.
    }
}