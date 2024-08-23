using CreationalPatterns_AbstractFactory.FactoryClass;
using CreationalPatterns_AbstractFactory.SubClasses;

class Program
{
    static void Main(string[] args)
    {
        IResturantFactory arabianResturant = new ArabianResturant();
        ISandwich arabianSandwich = arabianResturant.CreateSandwich();
        arabianSandwich.PrintData();
        // Output: i'm a Flaffl and Fol, My Main Ingerdian is Beans and i'm a Vegetarian.
        IMainDish arabianDish = arabianResturant.CreateDish();
        arabianDish.PrintDate();
        // Output: the name of the Dish is Koshari and the what we can say about this dish is : made
        // with love from the egyption Cuisine, made of manily rice and macaroni with some fried onions
        // and some tomato sauce.


        IResturantFactory foreignResturant = new ForeignResturant();
        ISandwich foreignSandwich = foreignResturant.CreateSandwich();
        foreignSandwich.PrintData();
        // Output: i'm a Caprese Sandwich, My Main Ingerdian is Fresh Mozzarella and i'm not a Vegetarian.

        IMainDish foreignDish = foreignResturant.CreateDish();
        foreignDish.PrintDate();
        // Output: the name of the Dish is Paella and the what we can say about this dish is : made with
        // love from Spain, with main ingrediant as rice and meat
    }
}