using BehavioralPatterns_Command.CommandBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns_Command.Models.Invokers
{
    public class Lieutenant
    {
        private readonly Soldier _soldier;

        public Lieutenant(Soldier soldier)
        {
            _soldier = soldier;
        }

        public void SetCommand(ICommand command)
        {
            _soldier.SetCommand(command);
        }

        public void OrderSoldierToExecute()
        {
            Console.WriteLine("Lieutenant orders the soldier...");
            _soldier.ExecuteCommand();
        }
    }
}
