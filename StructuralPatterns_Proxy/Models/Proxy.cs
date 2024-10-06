using StructuralPatterns_Proxy.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns_Proxy.Models
{
    public class Proxy : ISubject
    {
        private RealSubject _realSubject;

        public Proxy(RealSubject realSubject)
        {
            _realSubject = realSubject;
        }

        public void Request()
        {
            // Pre-processing task: Logging before calling the real object
            Console.WriteLine("Proxy: Logging before accessing RealSubject.");

            // Pre-processing task: Lazy initialization (if realSubject is null)
            if (_realSubject == null)
            {
                _realSubject = new RealSubject();
            }

            // Forward the request to the real object
            _realSubject.Request();

            // Post-processing task: Logging after calling the real object
            Console.WriteLine("Proxy: Logging after accessing RealSubject.");

            // Post-processing task: You could also add caching, result manipulation, etc.
        }
    }

}
