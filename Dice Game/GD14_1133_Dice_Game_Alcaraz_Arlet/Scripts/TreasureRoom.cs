using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GD14_1133_Dice_Game_Alcaraz_Arlet.Scripts
{
    internal class TreasureRoom : Room
    {
        Player player = new Player();
        public void SearchRoom()
        {
            Console.WriteLine("You see in the middle a chest, you open it and get a D1"); //Player searches the room and gets the dice
            player.availableDice.Add("D1", 1);
        }
    }
}
