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
    }
}
