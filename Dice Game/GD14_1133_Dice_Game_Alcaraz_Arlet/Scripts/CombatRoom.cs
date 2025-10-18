using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GD14_1133_Dice_Game_Alcaraz_Arlet.Scripts
{
    internal class CombatRoom : Room
    {
        private List<Player> turnOrder = new List<Player>();
        private Weapon.Sword sword;
        private Weapon.Maze maze;
        Monster cpu;

        internal override void SearchRoom()
        {
            Console.WriteLine("You search for anything usable, but the monsters don't have anything of value on them.");
        }
        
        internal override string GetNameRoom()
        {
            return "Combat Room";
        }
        internal override void OnEnter(Player user)
        {
            base.OnEnter(user);
            // Print a message about entering the new room
            // UNIQUE: Combat begins
            Console.WriteLine("A big scary monster attacks you!");
            CombatStarts();
            // TODO Start the combat

        }
    
        internal override void OnExit()
        {
            Console.WriteLine("You leave the room with the dead monster behind.");
        }


        public void CombatStarts()
        {
            
            Console.WriteLine("You see the monster in front of you, staring at your soul before attacking you!\n"); //Here is where the game starts again
            //turnOrder.Add(Monster.cpu);
            turnOrder.Add(cpu);
            turnOrder.Add(GameManager.player);
            CombatLoop();
            //while (turnOrder[0].HP > 0)
            //{
            //    for (int i = 0; i < turnOrder.Count; i++)  //This only happens twice, so its first turn and second turn
            //    {
            //        Player player = turnOrder[i];
            //        int rollerResults;
            //        string playerChoice;
            //        if (player == cpu)
            //        {
            //            playerChoice = player.CPUChoice();
            //            rollerResults = TakingTurn(player, playerChoice);
            //            cpuDamage = rollerResults;
            //            Console.WriteLine("The monster grabs his maze and hits you, dealing:" + cpuDamage + "\n");
            //        }
            //        else
            //        {
            //            playerChoice = player.PlayerChoice();
            //            rollerResults = TakingTurn(player, playerChoice);
            //            playerDamage = rollerResults;
            //            Console.WriteLine("You grab your weapon and hit the monster, dealing:" + playerDamage + "\n");
            //        }
            //    }
            //}
            //Round();


        }
        //private int TakingTurn(Player player, string die) //Here is where the magic happens with the rolles, the dieroller gets the result based on the player or cpu input
        //{
        //    int numFaces = player.inventory[item];
        //    int rollerResult = 0;
        //    string singularResults = player.username + " grabs the " + die + " and rolls it 3 times, the results are:";

        //    for (int i = 0; i < 3; i++)
        //    {
        //        int thisRolle = dieRoller.RollDice(numFaces);
        //        rollerResult += thisRolle;
        //        singularResults += " " + thisRolle + ",";
        //    }
        //    Console.WriteLine(singularResults);
        //    player.availableItems.Remove(die);
        //    return rollerResult;
        //}
        //private void Round()
        //{
        //    int cpuDamage = 0;
        //    int playerDamage = 0;
        //    while (turnOrder[0].HP > 0)
        //    {
        //        for (int i = 0; i < turnOrder.Count; i++)  //This only happens twice, so its first turn and second turn
        //        {
        //            Player player = turnOrder[i];
        //            int rollerResults;
        //            string playerChoice;
        //            if (player == cpu)
        //            {
        //                cpuDamage = player.CpuDamage();
        //                Console.WriteLine("The monster grabs his maze and hits you, dealing:" + cpuDamage + "\n");
        //            }
        //            else
        //            {
        //                playerChoice = player.PlayerChoice();
        //                rollerResults = TakingTurn(player, playerChoice);
        //                playerDamage = rollerResults;
        //                Console.WriteLine("You grab your weapon and hit the monster, dealing:" + playerDamage + "\n");
        //            }
        //        }
        //    }
        //}
        private string PlayerChoice()
        {
            bool valid = false;
            //Tell player inventory
            Console.WriteLine(GameManager.player.username + " current HP: " + GameManager.player.HP + "\n");
            Console.WriteLine(GameManager.player.username + " you have the following items in your inventory: ");
            foreach (var item in GameManager.player.inventory)
            {
                Console.WriteLine($"{item.Name}");
            }
            string playerInput;
            //Validate input
            do
            {
                //Ask player input
                Console.WriteLine("What weapon do you want to use?\n");
                //ReadLine of the option
                playerInput = Console.ReadLine();
                switch (playerInput)
                {
                    case "Sword":
                        valid = true;
                        break;
                    case "Maze":
                        valid = true;
                        break;
                    case "Small Potion":
                        valid = true; break;
                    case "Normal Potion":
                        valid = true; break;
                    case "Large Potion":
                        valid= true; break;
                    default:
                        Console.WriteLine("That's not an option");
                        valid = false;
                        break;
                }
            } while (valid == false);

            //Return Choice

            return playerInput;
        }
        private void ResolveCombatChoice(string playerInput)
        {
            switch (playerInput)
            {
                case "Sword":
                    Console.WriteLine("Sword hit, the monster dies with one hit");
                    //sword.Hit();
                    break;
                case "Maze":
                    Console.WriteLine("Maze hit, the monster dies with one hit");
                    //maze.Hit();
                    break;
                case "Small Potion":
                    Console.WriteLine("You use the small potion");
                    break;
                case "Normal Potion":
                    Console.WriteLine("You use the normal potion");
                    break;
                case "Large Potion":
                    Console.WriteLine("You use the large potion");
                    break;
                default:
                    Console.WriteLine("I couldn't resolve the input of " + playerInput);
                    break;
            }
        }
        private void CombatLoop()
        {
            string playerInput;
            playerInput = PlayerChoice();
            ResolveCombatChoice(playerInput);
        }
    }
}
