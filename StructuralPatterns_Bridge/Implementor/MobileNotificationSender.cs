using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns_Bridge.Implementor
{
    internal class MobileNotificationSender : INotificationSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Sending Mobile Notification: {message}");
        }
    }
}
