using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterens_Adapter.AdapteeClasses
{
    // European socket providing specific voltage and plug type
    public class EuropeanSocket : IPowerSocket
    {
        public void ProvidePower()
        {
            Console.WriteLine("Providing 230V power using a round plug (EuropeanSocket).");
        }
    }

}
