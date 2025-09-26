using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GD14_1133_Dice_Game_Alcaraz_Arlet.Scripts
{
    internal class GameManager
    {
        public static void ProgramStart()
        {
            Player.User(); //Decided to add this one first so it looks more clean
            Intro(); 
            RollOrDie();
            Outro();
        }
        private static void Intro()
        {
            Console.WriteLine("Let's roll some dice! May the odds be ever in your favor");
            Console.WriteLine(); 
        }
        private static void RollOrDie()
        {
            RandomTurn.Turn();
        }
        private static void Outro()
        {
            Console.WriteLine();
            Console.WriteLine("Thanks for giving this a try! Have a wonderful day!");
        }
    }
}
