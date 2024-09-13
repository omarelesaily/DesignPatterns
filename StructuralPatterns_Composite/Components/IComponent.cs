using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns_Composite.Components
{
    public interface IComponent
    {
        void Display(int depth);
    }
}
