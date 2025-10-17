using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GD14_1133_Dice_Game_Alcaraz_Arlet.Scripts
{
    internal class GameManager
    {
        private List<Player> turnOrder = new List<Player>();  //Declared the players first so i can access it in every function

        private Player player = new Player();

        Player cpu = new Player();
        DieRoller roller = new DieRoller();
        int playerscore = 0;
        int cpuscore = 0;
        DateOnly today = DateOnly.FromDateTime(DateTime.Now);
       
        private Map Map = new Map();

        private Room playerCurrentRoom;
        private Room playerLastRoom;

        // constants
        private const int MapX = 3;
        private const int MapY = 3;

        private bool gameIsRunning = false;

        public void ProgramStart()
        {
            // What does the game need to do Arlet?
            // Say Hello
            Intro();
            // Get Player Name
            player.User(); //Fixed how the intro is since it was rude to start by asking the player name

            // TODO Ask if ready to play * slightly different message than "play again"
            // TODO put into a function
            Console.WriteLine("Do you want to wander the world? Input \"yes\" to continue");
            gameIsRunning = Console.ReadLine() == "yes";

            // * GameLoop begins * * Ending on player reaching 0 hp || surrender || win condition
           
            while (gameIsRunning)
            {
                // At the start of the loop set any variables that will need to reset when the game resets (i.e. play again)
                InitializeNewGame();

                // Enter the first room
                playerCurrentRoom.OnEnter(player);

                // Setup is complete
                // Begin the player loop
                GameDecisionLoop();

                // Ask the player if they want to play again
                Console.WriteLine("Try again? Input \"yes\"");
                gameIsRunning = Console.ReadLine() == "yes";
            }

            // Final goodbye message REGARDLESS OF WHETHER THEY WON OR LOST, this is just the final goodbye
            Console.Write("The program will now close. Thank you.");
        }

        private void InitializeNewGame()
        {
            // Initialize Map
            Map.InitializeFlexible(MapX, MapY); //Initialized the map and assigned rooms

            // Set the player current room
            // MUST BE DONE AFTER MAKING THE MAP!
            playerCurrentRoom = Map.StartRoom(1, 1);

            // TODO
            // Set up the Player, reset player, default equipment, etc etc.
            player.Reset();
        }

        private void GameDecisionLoop()
        {
            while (gameIsRunning)
            {
                bool validInput;
                string choice;
                // Input validation loop
                do
                {
                    choice = GetPlayerChoiceForCurrentStep();
                    validInput = choice != "Error";
                }
                while (validInput == false);

                ResolveCurrentChoice(choice);
                // What CAN happen based on their choices?
                // 1 Move
                // 2 Inventory
                // 3 Surrender
                // 4 Test fight
                // these will have to resolve however they need to
                // then the game should should come back to this point

                // If the player dies during a combat, then gameIsRunning will be false, and we will not loop.
            }
        }

        //public void GameLoop()
        //{
        //    cpu.username = "Arlet";
        //    player.Initialize();
        //    cpu.Initialize();  //Moved the game loop on its own place
        //    Rules();
        //    DecideTurnOrder();
        //    RoundLoop();
        //}
        private void Intro()
        { //This greats the player and shows the game name
            Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
            Console.WriteLine("Hello, hello hello! Uh, welcome to");
            Console.WriteLine(" ___   ___   _     _         ___   ___       ___   _   ____ \r\n| |_) / / \\ | |   | |       / / \\ | |_)     | | \\ | | | |_  \r\n|_| \\ \\_\\_/ |_|__ |_|__     \\_\\_/ |_| \\     |_|_/ |_| |_|__ \r\n                                                            \r\n                                                            \r\n                                                            ");
            Console.WriteLine("A place where your soul is at stake!");
            Console.WriteLine("Today is: " + today);
            Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
            Console.WriteLine();
        }
       
        private void Outro()
        { //This is where we say goodbye to the player
            Console.WriteLine();
            Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
            Console.WriteLine("Thank you for keeping me entertained dear wandering soul~");
            Console.WriteLine("You fought for your soul with great bravery; you can keep it...");
            Console.WriteLine("░        ░░░      ░░░       ░░░░░░░░░   ░░░  ░░░      ░░░  ░░░░  ░\r\n▒  ▒▒▒▒▒▒▒▒  ▒▒▒▒  ▒▒  ▒▒▒▒  ▒▒▒▒▒▒▒▒    ▒▒  ▒▒  ▒▒▒▒  ▒▒  ▒  ▒  ▒\r\n▓      ▓▓▓▓  ▓▓▓▓  ▓▓       ▓▓▓▓▓▓▓▓▓  ▓  ▓  ▓▓  ▓▓▓▓  ▓▓        ▓\r\n█  ████████  ████  ██  ███  █████████  ██    ██  ████  ██   ██   █\r\n█  █████████      ███  ████  ████████  ███   ███      ███  ████  █\r\n                                                                  ");
            Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
        }
        private void Rules()
        { //The rules of the game
            Console.WriteLine();
            Console.WriteLine("You and I will have 7 dice at our disposal:");
            Console.WriteLine("D4 / D6 / D8 / D10 / D12 / D20 / D100");
            Console.WriteLine();
            Console.WriteLine("Each round we will choose a die and roll that same die 3 times, adding the results of each roll, \nwhoever gets the highest number wins a point, do know you and I can pick different die to use.");
            Console.WriteLine("The turns will be determined at the start of the first round, setting the turns for all the rounds.");
            Console.WriteLine("But! If the result is a tie the die will be rerolled.");
            Console.WriteLine($"Be aware " + player.username + " that once a die is used it will disappear never to be seen again.\n");
        }

        private void DecideTurnOrder()
        { //Here is where the turn is decided for the rest of the game
            Console.WriteLine("Let's decide who starts:\n");

            Random coinRandom = new Random();
            int coinResult = coinRandom.Next(0, 2);
            if (coinResult == 0)
            {
                //Player starts
                turnOrder.Add(player);
                turnOrder.Add(cpu);
            }
            else
            {
                //Cpu starts
                turnOrder.Add(cpu);
                turnOrder.Add(player);
            }
            Console.WriteLine(turnOrder[0].username + " starts!");
        }
        private int TakingTurn(Player player, string die) //Here is where the magic happens with the rolles, the dieroller gets the result based on the player or cpu input
        {
            int numFaces = player.availableDice[die];
            int rollerResult = 0;
            string singularResults = player.username + " grabs the " + die + " and rolls it 3 times, the results are:";

            for (int i = 0; i < 3; i++)
            {
                int thisRolle = roller.RollDice(numFaces);
                rollerResult += thisRolle;
                singularResults += " " + thisRolle + ",";
            }
            Console.WriteLine(singularResults);
            player.availableDice.Remove(die);
            return rollerResult;
        }
        private void RoundLoop() //Tried to make it as clean as i could
        {
            int cpuRollerResults = 0;
            int playerRollerResult = 0;
            while (turnOrder[0].availableDice.Count > 0)
            {
                for (int i = 0; i < turnOrder.Count; i++)  //This only happens twice, so its first turn and second turn
                {
                    Player player = turnOrder[i];
                    int rollerResults;
                    string playerChoice;
                    if (player == cpu)
                    {
                        playerChoice = player.CPUChoice();
                        rollerResults = TakingTurn(player, playerChoice);
                        cpuRollerResults = rollerResults;
                    }
                    else
                    {
                        playerChoice = player.PlayerChoice();
                        rollerResults = TakingTurn(player, playerChoice);
                        playerRollerResult = rollerResults;
                    }
                }
                Console.WriteLine("The final sum is:");
                Console.WriteLine(player.username + "--> " + playerRollerResult);
                Console.WriteLine(cpu.username + "--> " + cpuRollerResults);
                Console.WriteLine();
                if (cpuRollerResults > playerRollerResult)
                {
                    Console.WriteLine(cpu.username + " wins a point!");
                    cpuscore++;
                }
                else
                {
                    Console.WriteLine(player.username + " wins a point!");
                    playerscore++;
                }
                Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-\n");
            }
            Console.WriteLine("And the winner is:\n");
            if (cpuscore > playerscore)
            {
                Console.WriteLine(cpu.username + "!!!\n");
            }
            else
            {
                Console.WriteLine(player.username + "!!!\n");
            }
            Console.WriteLine("The final score is:\n");
            Console.WriteLine(cpu.username + "--> " + cpuscore);
            Console.WriteLine();
            Console.WriteLine(player.username + "--> " + playerscore);
        }

        public string GetPlayerChoiceForCurrentStep()
        {
            // Show the player all their options.
            // Validate their input
            // Get their decision
            Console.WriteLine("=======");
            Console.WriteLine("Rooms Visited: " + player.NumberOfRoomsVisited + " of " + Map.NumberOfRooms);
            Console.WriteLine("You are in " + playerCurrentRoom.GetNameRoom() + ", what do you want to do now?\n"); //I give the player its options
            Console.WriteLine("1.-Move\n2.-Check your inventory\n3.-Give up your soul to me\n4.-Search the room");

            string decision = Console.ReadLine();
            switch (decision)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                    return decision;
                default:
                    return "Error";
            }
        }

        public void ResolveCurrentChoice(string decision)
        {
            switch (decision)
            {
                case "1":
                    playerCurrentRoom = Map.MoveDecisionLoop(playerCurrentRoom, player);
                    break;
                case "2":
                    player.Inventory(); //Here it prints the player inventory
                    Console.WriteLine();
                    break;
                case "3":
                    gameIsRunning = false;
                    Outro(); //Ends the run
                    break;
                case "4":
                    {
                        playerCurrentRoom.SearchRoom();
                        break;
                    }
                // TEST COMBAT
                //case "5":
                //    {
                //        CombatRoom _combat = new CombatRoom();
                //        _combat.CombatStarts();
                //        break;
                //    }
                default:
                    Console.WriteLine("I couldn't resolve the input of " + decision);
                    break;
            }
        }
    }
}