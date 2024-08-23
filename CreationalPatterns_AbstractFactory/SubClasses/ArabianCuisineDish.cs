using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns_AbstractFactory.SubClasses
{
    public class ArabianCuisineDish : IMainDish
    {
        public string Name { get; set; } = "Koshari";// the fireign is Paella 

        public string Description { get; set; } = "made with love from the egyption Cuisine, made of manily rice and macaroni with some fried onions and some tomato sauce.";

    }
}
