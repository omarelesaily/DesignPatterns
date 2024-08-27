using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns_Bridge.Implementor
{
    public interface INotificationSender
    {
        void SendMessage(string message);
    }
}
