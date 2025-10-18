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

        public int NumberOfRooms => _map.Length;

        public void InitializeFlexible(int x, int y)
        {
            _map = new Room[x, y];

            for (int i = 0; i < x; i++) 
            {
                for (int j = 0; j < y; j++)
                {
                    SetRoom(i, j); //Room gets selected and assigned
                    //The rooms get linked here
                }
            }
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    //The rooms get linked here
                    Room currentRoom = _map[i, j];
                    if (i > 0) currentRoom.NorthRoom = _map[i - 1, j];       //Checks if there can be a north room
                    if (i < y - 1) currentRoom.SouthRoom = _map[i + 1, j];   //Checks if there can be a south room 
                    if (j > 0) currentRoom.WestRoom = _map[i, j - 1];       //Checks if there can be a west room
                    if (j < x - 1) currentRoom.EastRoom = _map[i, j + 1];   //Checks if there can be an east room
                }
            }
        }
        public Room StartRoom(int x , int y) //Here is where i make the player start location
        {
            return _map[1, 1]; //Returns the middle room as the start
        }
        public Room GetRoom(int x, int y)
        {
            return _map[x, y];
        }
        public void SetRoom(int x, int y)
        {
            Room room;
            Random rand = new Random(); //Does a random to decide if the room will have a combat or treasure
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

        //public void MoveRooms(Room currentRoom)
        //{
        //    Console.WriteLine("Where do you want to go?\n");
        //    Console.WriteLine("North, South, West or East?\n");
        //    string roomSelect = Console.ReadLine();
        //    switch (roomSelect)
        //    {
        //        case "North":
        //            if (currentRoom.NorthRoom == null)
        //            {
        //                Console.WriteLine("You can't go up!");
        //                MoveRooms(currentRoom);
        //            }
        //            else
        //            {
        //                currentRoom.OnExit();
        //                currentRoom = currentRoom.NorthRoom;
        //                currentRoom.OnEnter();
        //            }
        //            break;
        //        case "South":
        //            if (currentRoom.SouthRoom == null)
        //            {
        //                Console.WriteLine("You can't go down!");
        //                MoveRooms(currentRoom);
        //            }
        //            else
        //            {
        //                currentRoom.OnExit();
        //                currentRoom = currentRoom.SouthRoom;
        //                currentRoom.OnEnter();
        //            }
        //            break;
        //        case "West":
        //            if (currentRoom.WestRoom == null)
        //            {
        //                Console.WriteLine("You can't go to the left!");
        //                MoveRooms(currentRoom);
        //            }
        //            else
        //            {
        //                currentRoom.OnExit();
        //                currentRoom = currentRoom.WestRoom;
        //                currentRoom.OnEnter();
        //            }
        //            break;
        //        case "East":
        //            if (currentRoom.EastRoom == null)
        //            {
        //                Console.WriteLine("You can't go to the right!");
        //                MoveRooms(currentRoom);
        //            }
        //            else
        //            {
        //                currentRoom.OnExit();
        //                currentRoom = currentRoom.EastRoom;
        //                currentRoom.OnEnter();
        //            }
        //            break;
        //        default:
        //            Console.WriteLine("Thats not a valid option, please try again");
        //            MoveRooms(currentRoom);
        //            break;
        //    }
        //}

        internal Room MoveDecisionLoop(Room currentRoom, Player user)
        {
            bool validInput;
            bool isRoomInDirection;
            string choice;
            do
            {
                // Input validation loop
                do
                {
                    choice = GetDirection(currentRoom);
                    validInput = choice != "Error";
                }
                while (validInput == false);

                if (choice == "Cancel") return currentRoom;

                // Is there a room in that direction?
                isRoomInDirection = IsRoomInDirection(currentRoom, choice);
                if (isRoomInDirection == false)
                    Console.WriteLine("No room that way!");
            }
            while (validInput == false);

            currentRoom.OnExit(); // 1,1
            currentRoom = MovePlayer(currentRoom, choice);
            currentRoom.OnEnter(user);
            return currentRoom;
        }

        public string GetDirection(Room currentRoom)
        {
            Console.WriteLine("Where do you want to go?\n");
            Console.WriteLine("North, South, West or East?\n");

            string decision = Console.ReadLine();
            switch (decision)
            {
                case "North":
                case "South":
                case "East":
                case "West":
                case "Cancel":
                    return decision;
                default:
                    return "Error";
            }
        }

        public bool IsRoomInDirection(Room currentRoom, string direction)
        {
            switch (direction)
            {
                case "North":
                    return currentRoom.NorthRoom != null;
                case "South":
                    return currentRoom.SouthRoom != null;
                case "East":
                    return currentRoom.EastRoom != null;
                case "West":
                    return currentRoom.WestRoom != null;
                default:
                    Console.WriteLine("IsRoomInDirection: Unknown direction! " + direction);
                    break;
            }
            return false;
        }

        public Room? MovePlayer(Room currentRoom, string direction)
        {
            switch (direction)
            {
                case "North":
                    return currentRoom.NorthRoom;
                case "South":
                    return currentRoom.SouthRoom;
                case "East":
                    return currentRoom.EastRoom;
                case "West":
                    return currentRoom.WestRoom;
                default:
                    Console.WriteLine("MovePlayer: Unknown direction! " + direction);
                    return null;
            }
        }

        public void Move()
        {
            Console.WriteLine("You try to move but fail");
        }
    }

}
