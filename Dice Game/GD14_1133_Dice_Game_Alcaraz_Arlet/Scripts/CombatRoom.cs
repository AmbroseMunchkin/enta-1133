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

            CombatLoop();
        }
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
            Consumable.SmallPotion smallPotion = new Consumable.SmallPotion();
            Consumable.NormalPotion normalPotion = new Consumable.NormalPotion();
            Consumable.LargePotion largePotion = new Consumable.LargePotion();
            Weapon.Sword sword = new Weapon.Sword();
            Weapon.Maze maze = new Weapon.Maze();
            switch (playerInput)
            {
                
                case "Sword":      //Activates the use of the option
                    sword.Used();
                    GameManager.player.inventory.Remove(sword);
                    break;
                case "Maze":
                    maze.Used();
                    GameManager.player.inventory.Remove(maze);
                    break;
                case "Small Potion":
                    smallPotion.Used();
                    GameManager.player.inventory.Remove(smallPotion);
                    break;
                case "Normal Potion":
                    normalPotion.Used();
                    GameManager.player.inventory.Remove(normalPotion);
                    break;
                case "Large Potion":
                    normalPotion.Used();
                    GameManager.player.inventory.Remove(largePotion);
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
            Console.WriteLine();
            Console.WriteLine("The monster tries to hit you but fails");
            playerInput = PlayerChoice();
            ResolveCombatChoice(playerInput);
            Console.WriteLine("The monster tries once more to hit you but fails, falling to the floor");
            playerInput = PlayerChoice();
            ResolveCombatChoice(playerInput);
            Console.WriteLine("The monster tries one last time, accidentally hitting himself");
            playerInput = PlayerChoice();
            ResolveCombatChoice(playerInput);
            Console.WriteLine();
            Console.WriteLine("You defeat the monster!");
        }
    }
}
