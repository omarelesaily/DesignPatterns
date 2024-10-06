using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns_Proxy.Models
{
    public class RealSubject
    {
        public void Request()
        {
            Console.WriteLine("RealSubject: Handling request.");
        }
    }
}
