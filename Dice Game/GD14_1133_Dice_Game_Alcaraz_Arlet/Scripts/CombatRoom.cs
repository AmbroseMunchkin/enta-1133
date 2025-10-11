using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GD14_1133_Dice_Game_Alcaraz_Arlet.Scripts
{
    internal class CombatRoom : Room
    {
        GameManager game = new GameManager();
        public void CombatStarts()
        {
            Player player = new Player();
            Console.WriteLine("You see a monster in front of you, he stares at your soul before attacking you!\n Combat starts!\n"); //Here is where the game starts again
            game.GameLoop();
        }
    }
}
