using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns_AbstractFactory.SubClasses
{
    public class ForeignCuisineDish : IMainDish
    {
        public string Name { get; set; } = "Paella";

        public string Description { get; set; } = "made with love from Spain, with main ingrediant as rice and meat";
    }
}
