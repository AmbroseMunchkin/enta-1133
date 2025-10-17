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
        Player player = new Player();
        internal override void SearchRoom()
        {
            Console.WriteLine("You see in the middle a chest, you open it and get:\n"); //Player searches the room and gets an item
            Random chestSpin = new Random();
            int chestResult = chestSpin.Next(0, 4);
            switch (chestResult)
            {
                case 1:
                    player.availableItems.Add("Small potion (D4)", 4);
                    Console.WriteLine("A small potion (D4)!!!");
                    break;
                case 2:
                    player.availableItems.Add("Normal potion (D6)", 6);
                    Console.WriteLine("A normal potion (D6)!!!");
                    break;
                case 3:
                    player.availableItems.Add("Large potion (D8)", 8);
                    Console.WriteLine("A large potion (D8)!!!");
                    break;
                default:
                    Console.WriteLine("You find the chest empty.\n");
                    break;
            }
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
