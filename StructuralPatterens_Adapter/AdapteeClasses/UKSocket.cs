using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterens_Adapter.AdapteeClasses
{
    // UK socket providing specific voltage and plug type
    public class UKSocket : IPowerSocket
    {
        public void ProvidePower()
        {
            Console.WriteLine("Providing 240V power using a rectangular plug (UKSocket).");
        }
    }
}
