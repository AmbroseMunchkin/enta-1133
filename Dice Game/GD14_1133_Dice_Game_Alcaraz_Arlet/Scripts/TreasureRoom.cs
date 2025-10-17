using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GD14_1133_Dice_Game_Alcaraz_Arlet.Scripts
{
    internal class TreasureRoom : Room
    {

        internal override void SearchRoom()
        {
            Console.WriteLine("You see in the middle a chest, you open it and get a D1"); //Player searches the room and gets the dice
            //player.availableDice.Add("D1", 1);
            // TODO Inventory code
        }
        internal override string GetNameRoom()
        {
            return "Treasure Room";
        }

        internal override void OnEnter(Player user)
        {
            base.OnEnter(user);
            // Print a message about entering the new room
            // UNIQUE: Part of the message should mention the chest
            Console.WriteLine("You see in the middle a chest");
            // Does not auto search the chest
        }

        internal override void OnExit()
        {
            Console.WriteLine("You leave the room with the chest behind");
        }
    }
}
