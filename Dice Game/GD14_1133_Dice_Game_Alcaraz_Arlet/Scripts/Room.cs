using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GD14_1133_Dice_Game_Alcaraz_Arlet.Scripts
{
    internal class Room
    {
        public Room? NorthRoom, SouthRoom, WestRoom, EastRoom;
        public void OnEnter()
        {
            Console.WriteLine("You enter a new room");
        }
        public void OnExit()
        {
            Console.WriteLine("You move to a different room");
        }
        public void Visited()
        {
            Console.WriteLine("You don't find anything new worth your time");
        }
    }
}
