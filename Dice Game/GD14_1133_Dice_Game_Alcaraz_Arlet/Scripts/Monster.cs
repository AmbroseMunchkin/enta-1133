using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GD14_1133_Dice_Game_Alcaraz_Arlet.Scripts
{
    internal class Monster : Player
    {
        public int MonsterHP = 0;

        public int MonsterDamage()
        {
            Random rand = new Random();
            int result = rand.Next(0, 9);
            return result;
        }
    }
}
