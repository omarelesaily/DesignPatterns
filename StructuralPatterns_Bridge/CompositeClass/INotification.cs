using StructuralPatterns_Bridge.Implementor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns_Bridge.CompositeClass
{
    // Composite class meaning the class that contains one or more than one object of another class
    internal interface INotification
    {
        void Send(string message);
    }
}
