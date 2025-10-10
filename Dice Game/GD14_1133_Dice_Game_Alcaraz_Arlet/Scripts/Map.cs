using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GD14_1133_Dice_Game_Alcaraz_Arlet.Scripts
{
    internal class Map
    {
        private Room[,] _map;
        private Room _treasureRoom = new Room();

        public void InitializeFlexible(int x, int y)
        {
            _map = new Room[x, y];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    //The rooms get linked here
                    Room currentRoom = _map[j, i];
                    if (i > 0) currentRoom.NorthRoom = _map[j, i - 1];
                    if (i < 3 - 1) currentRoom.SouthRoom = _map[j, i - 1];
                    if (j > 0) currentRoom.WestRoom = _map[j - 1, i];
                    if (j > 3 - 1) currentRoom.EastRoom = _map[j, i - 1];
                }
            }
        }
        public Room GetRoom(int x, int y)
        {
            return _map[x, y];
        }
        public void SetRoom(int x, int y)
        {
            Room room;
            Random rand = new Random();
            int randomNum = rand.Next(0, 2);
            if (randomNum == 1)
            {
                room = new TreasureRoom();
            }
            else
            {
                room = new CombatRoom();
            }
            _map[x, y] = room;
        }
        public void MoveRooms(Room currentRoom)
        {
            if (currentRoom.NorthRoom == null)
            {
                Console.WriteLine("You can't go up!");
            }
            else
            {
                currentRoom.OnExit();
                currentRoom = currentRoom.NorthRoom;
            }
            currentRoom.OnEnter();
        }
    }

}
