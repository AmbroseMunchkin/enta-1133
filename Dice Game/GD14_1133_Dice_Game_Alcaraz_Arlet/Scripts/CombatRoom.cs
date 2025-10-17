using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GD14_1133_Dice_Game_Alcaraz_Arlet.Scripts
{
    internal class CombatRoom : Room
    {

        internal override void SearchRoom()
        {
            Console.WriteLine("You search for anything usable, but the monsters don't have anything of value on them.");
        }
        
        internal override string GetNameRoom()
        {
            return "Combat Room";
        }

        internal override void OnEnter(Player user)
        {
            base.OnEnter(user);
            // Print a message about entering the new room
            // UNIQUE: Combat begins
            Console.WriteLine("A big scary monster attacks you!");
            // TODO Start the combat

        }

        internal override void OnExit()
        {
            Console.WriteLine("You leave the room with the dead monsters behind.");
        }


        public void CombatStarts()
        {
            Console.WriteLine("You see a monster in front of you, he stares at your soul before attacking you!\n Combat starts!\n"); //Here is where the game starts again
        }
    }
}
