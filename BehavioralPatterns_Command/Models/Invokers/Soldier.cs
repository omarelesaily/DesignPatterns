using BehavioralPatterns_Command.CommandBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns_Command.Models.Invokers
{
    public class Soldier
    {
        private ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void ExecuteCommand()
        {
            if (_command != null)
            {
                Console.WriteLine("Soldier is executing the command...");
                _command.Execute();
            }
        }
    }
}
