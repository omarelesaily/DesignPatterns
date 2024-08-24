using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns_Builder.SubCLasses
{
    public class Sandwich
    {
        public string Bread { get; set; }
        public string Spread { get; set; }
        public string Fillings { get; set; }
        public void PrintData() {
            string bread = Bread ?? "Unnammed Bread";
            string spread = Spread ?? "Unnammed Spread";
            string fillings = Fillings ?? "Unnammed Fillings";

            Console.WriteLine($"Sandwich with Bread: {bread}, Spread: {spread}, Fillings: {fillings}.");

        }
    }
}
