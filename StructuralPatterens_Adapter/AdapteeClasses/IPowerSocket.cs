using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterens_Adapter.AdapteeClasses
{
    // Base class representing a general power socket
    public interface IPowerSocket
    {
        public void ProvidePower();
    }

}
