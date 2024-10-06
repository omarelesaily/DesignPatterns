using BehavioralPatterns_Command.CommandBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns_Command.Models.Invokers
{
    public class General
    {
        private readonly Lieutenant _lieutenant;

        public General(Lieutenant lieutenant)
        {
            _lieutenant = lieutenant;
        }

        public void SetCommand(ICommand command)
        {
            _lieutenant.SetCommand(command);
        }

        public void OrderLieutenant()
        {
            Console.WriteLine("General orders the lieutenant...");
            _lieutenant.OrderSoldierToExecute();
        }
    }
}
