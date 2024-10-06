using BehavioralPatterns_Command.Models.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns_Command.CommandBehavior
{
    public class FireWeaponCommand : ICommand
    {
        private readonly Weapon _weapon;

        public FireWeaponCommand(Weapon weapon)
        {
            _weapon = weapon;
        }

        public void Execute()
        {
            _weapon.Fire();
        }
    }
}
