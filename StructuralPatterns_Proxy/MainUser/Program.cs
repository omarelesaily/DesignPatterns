
using StructuralPatterns_Proxy.Models;

namespace StructuralPatterns_Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            RealSubject realSubject = new RealSubject();
            Proxy proxy = new Proxy(realSubject);

            proxy.Request();
        }
    }
}
