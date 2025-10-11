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

        public void InitializeFlexible(int x, int y)
        {
            _map = new Room[x, y];

            for (int i = 0; i < x; i++) 
            {
                for (int j = 0; j < y; j++)
                {
                    SetRoom(i, j); //Room gets selected and assigned
                    //The rooms get linked here
                    Room currentRoom = _map[i, j];
                    if (j > 0) currentRoom.NorthRoom = _map[i, j - 1];       //Checks if there can be a north room
                    if (j < i - 1) currentRoom.SouthRoom = _map [i, j + 1];   //Checks if there can be a south room 
                    if (i > 0) currentRoom.WestRoom = _map[i - 1, j];       //Checks if there can be a west room
                    if (i < j - 1) currentRoom.EastRoom = _map[i + 1, j];   //Checks if there can be an east room
                }
            }
        }
        public Room StartRoom(int x , int y) //Here is where i make the player start location
        {
            return _map[1, 1];
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
            Console.WriteLine("Where do you want to go?\n");
            Console.WriteLine("North, South, West or East?\n");
            string roomSelect = Console.ReadLine();
            if (roomSelect == "North")
            {
                if (currentRoom.NorthRoom == null)
                {
                    Console.WriteLine("You can't go up!");
                    MoveRooms(currentRoom);
                }
                else
                {
                    currentRoom.OnExit();
                    currentRoom = currentRoom.NorthRoom;
                    currentRoom.OnEnter();
                }
            }
            else if (roomSelect == "South")
            {
                if (currentRoom.SouthRoom == null)
                {
                    Console.WriteLine("You can't go down!");
                    MoveRooms(currentRoom);
                }
                else
                {
                    currentRoom.OnExit();
                    currentRoom = currentRoom.SouthRoom;
                    currentRoom.OnEnter();
                }
            }
            else if (roomSelect == "West")
            {
                if (currentRoom.WestRoom == null)
                {
                    Console.WriteLine("You can't go to the left!");
                    MoveRooms(currentRoom);
                }
                else
                {
                    currentRoom.OnExit();
                    currentRoom = currentRoom.WestRoom;
                    currentRoom.OnEnter();
                }
            }
            else if (roomSelect == "East")
            {
                if (currentRoom.EastRoom == null)
                {
                    Console.WriteLine("You can't go to the right!");
                    MoveRooms(currentRoom);
                }
                else
                {
                    currentRoom.OnExit();
                    currentRoom = currentRoom.EastRoom;
                    currentRoom.OnEnter();
                }
            }
            else
            {
                Console.WriteLine("Thats not a valid option, please try again");
                MoveRooms(currentRoom);
            }
        }
        public void Move()
        {
            Console.WriteLine("You try to move but fail");
        }
    }

}
