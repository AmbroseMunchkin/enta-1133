using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GD14_1133_Dice_Game_Alcaraz_Arlet.Scripts
{
    internal class Room
    {
        Map _map = new Map();
        public Room? NorthRoom, SouthRoom, WestRoom, EastRoom;
        Room currentRoom;
        GameManager manager = new GameManager();
        public void OnEnter()
        {
            string decision = "";
            Console.WriteLine("You enter a new room, what do you want to do?\n");
            Console.WriteLine("1.-Search\n2.-Move to a different room\n");
            decision = Console.ReadLine();
            if (decision == "1")
            {
                Console.WriteLine("You search the room and find nothing");
                manager.PlayerChoice();

            }
            else if (decision == "2")
            {
                _map.MoveRooms(currentRoom);
            }
        }
        public void OnExit()
        {
            Console.WriteLine("You move to a different room");
        }
        public void Visited()
        {
            Console.WriteLine("You don't find anything new worth your time");
        }
        public virtual string GetNameRoom()
        {
            
            return "UnknownRoom";
        }
    }
}
