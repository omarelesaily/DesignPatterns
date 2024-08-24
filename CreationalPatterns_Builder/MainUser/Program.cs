using CreationalPatterns_Builder.Builder;
using CreationalPatterns_Builder.SubCLasses;

class Program
{
    static void Main(string[] args)
    {
        ISandwichBuilder sandwichBuilder=new SandwichBuilder();
        Resturant resturant=new Resturant();

        var flaflSandwich=resturant.BuildFlaflSandwich(sandwichBuilder);
        flaflSandwich.PrintData();
        //OutPut : Sandwich with Bread: Local Egyption bread, Spread: Tahene, Fillings: Flafl and salad.

        var chickenWrapSandwich = resturant.BuildChichenWrapSandwich(sandwichBuilder);
        chickenWrapSandwich.PrintData();
        //OutPut : Sandwich with Bread: Tortilla Wrap, Spread: Caesar Dressing, Fillings: Grilled Chicken Breast.
    }

}