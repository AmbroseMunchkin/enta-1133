using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GD14_1133_Dice_Game_Alcaraz_Arlet.Scripts
{
    internal abstract class Room
    {
        internal Room? NorthRoom, SouthRoom, WestRoom, EastRoom;

        private bool visited = false;

        internal virtual void OnEnter(Player user)
        {
            // Mark the room as visited
            Visited(user);
        }

        internal abstract void OnExit();
        internal abstract void SearchRoom();
        internal abstract string GetNameRoom();

        internal void Visited(Player user)
        {
            if (!visited)
            {
                visited = true;
                user.NumberOfRoomsVisited++;
            }
        }













        //public void OnEnterOLD()
        //{
        //    string decision = "";
        //    Console.WriteLine("You enter a new room, what do you want to do?\n");
        //    Console.WriteLine("1.-Search\n2.-Move to a different room\n");
        //    decision = Console.ReadLine();
        //    if (decision == "1")
        //    {
        //        Console.WriteLine("You search the room and find nothing");
        //        //manager.PlayerChoice();

        //    }
        //    else if (decision == "2")
        //    {
        //        _map.MoveRooms(currentRoom);
        //    }
        //}
        //public void OnExitOLD()
        //{
        //    Console.WriteLine("You move to a different room");
        //}
        //public void VisitedOLD()
        //{
        //    Console.WriteLine("You don't find anything new worth your time");
        //}
        //public virtual string GetNameRoomOLD()
        //{
            
        //    return "UnknownRoom";
        //}
    }
}
