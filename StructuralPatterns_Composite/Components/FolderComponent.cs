using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns_Composite.Components
{
    public class FolderComponent : IComponent
    {
        private readonly string _name;
        private readonly List<IComponent> _components = new();

        public FolderComponent(string name)
        {
            _name = name;
        }

        public void Add(IComponent component)
        {
            _components.Add(component);
        }

        public void Remove(IComponent component)
        {
            _components.Remove(component);
        }

        public void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + " Folder: " + _name);
            foreach (var component in _components)
            {
                component.Display(depth + 2);
            }
        }
    }
}
