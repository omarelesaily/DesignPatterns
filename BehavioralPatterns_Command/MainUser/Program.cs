using BehavioralPatterns_Command.CommandBehavior;
using BehavioralPatterns_Command.Models.Invokers;
using BehavioralPatterns_Command.Models.Receivers;

namespace BehavioralPatterns_Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapon weapon = new Weapon();

            ICommand fireCommand = new FireWeaponCommand(weapon);

            Soldier soldier = new Soldier();

            Lieutenant lieutenant = new Lieutenant(soldier);

            General general = new General(lieutenant);

            general.SetCommand(fireCommand);

            general.OrderLieutenant();

            // Output:
            // General orders the lieutenant...
            // Lieutenant orders the soldier...
            // Soldier is executing the command...
            // Weapon is fired!
        }
    }
}