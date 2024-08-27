using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterens_Adapter.AdapteeClasses
{
    // Indian socket providing specific voltage and plug type
    public class IndianSocket : IPowerSocket
    {
        public void ProvidePower()
        {
            Console.WriteLine("Providing 230V power using a three-pin plug (IndianSocket).");
        }
    }
}
