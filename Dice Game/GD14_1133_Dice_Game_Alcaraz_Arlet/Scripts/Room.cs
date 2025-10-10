using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GD14_1133_Dice_Game_Alcaraz_Arlet.Scripts
{
    internal class Room
    {
        public string NorthRoom, SouthRoom, WestRoom, EastRoom;
        public void OnEnter()
        {
            Console.WriteLine("You enter the room and find a chest in the middle, you open it and find:");

        }
        public void OnExit()
        {

        }
    }
}
