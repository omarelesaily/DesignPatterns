using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns_Composite.Components
{
    public class FileComponent : IComponent
    {
        private readonly string _name;

        public FileComponent(string name)
        {
            _name = name;
        }

        public void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + " File: " + _name);
        }
    }

}
