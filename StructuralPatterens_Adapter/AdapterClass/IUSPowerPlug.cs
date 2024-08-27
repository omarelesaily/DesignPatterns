using StructuralPatterens_Adapter.AdapteeClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterens_Adapter.AdapterClass
{
    // Target interface: The voltage and plug type your device expects
    public interface IUSPowerPlug
    {
        void ProvidePower();
    }
    // Adapter: Converts any PowerSocketBase to US-compatible power
    public class UniversalPowerAdapter : IUSPowerPlug
    {
        private readonly IPowerSocket _powerSocket;

        public UniversalPowerAdapter(IPowerSocket powerSocket)
        {
            _powerSocket = powerSocket;
        }

        public void ProvidePower()
        {
            // Use the method from the base class
            _powerSocket.ProvidePower();
            Console.WriteLine("Converted to 120V power using a flat plug (US standard).");
        }
    }
}