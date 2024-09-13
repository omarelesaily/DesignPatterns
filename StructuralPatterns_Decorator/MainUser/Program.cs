using StructuralPatterns_Decorator.Components;
using StructuralPatterns_Decorator.Decorators;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Start with a simple coffee
            ICoffee coffee = new SimpleCoffee();
            Console.WriteLine($"{coffee.GetDescription()} costs {coffee.GetCost()}");

            // Add Milk
            coffee = new MilkDecorator(coffee);
            Console.WriteLine($"{coffee.GetDescription()} costs {coffee.GetCost()}");

            // Add Sugar
            coffee = new SugarDecorator(coffee);
            Console.WriteLine($"{coffee.GetDescription()} costs {coffee.GetCost()}");

            // Add Whipped Cream
            coffee = new WhippedCreamDecorator(coffee);
            Console.WriteLine($"{coffee.GetDescription()} costs {coffee.GetCost()}");
        }
    }
}
