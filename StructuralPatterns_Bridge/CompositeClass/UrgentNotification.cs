using StructuralPatterns_Bridge.Implementor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns_Bridge.CompositeClass
{
    public class UrgentNotification : INotification
    {
        private readonly INotificationSender _sender;

        public UrgentNotification(INotificationSender sender)
        {
            _sender = sender;
        }

        public void Send(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Urgent Notification: in Red Color");
            _sender.SendMessage(message);
        }
    }
}
