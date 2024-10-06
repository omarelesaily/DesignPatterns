using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPatterns_Command.Models.Receivers
{
    public class Weapon
    {
        public void Fire()
        {
            Console.WriteLine("Weapon is fired!");
        }
    }
}
