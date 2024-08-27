using StructuralPatterns_Bridge.Implementor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns_Bridge.CompositeClass
{
    internal class RegularNotification : INotification
    {
        private readonly INotificationSender _sender;

        public RegularNotification(INotificationSender sender)
        {
            _sender = sender;
        }

        public void Send(string message)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Regular Notification: in White Color");
            _sender.SendMessage(message);
        }
    }
}
