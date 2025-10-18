using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GD14_1133_Dice_Game_Alcaraz_Arlet.Scripts
{
    internal abstract class Weapon : Item
    {
        internal abstract int Hit();
        public class Sword : Weapon
        {
            int minRoll = 0;
            int maxRoll = 6;
            int damage = 0;
            internal override int Hit()
            {
                damage = Roll();
                Console.WriteLine("You hit the moster with the sword, it makes " + damage + " damage!");
                return damage;
            }
            internal override int Roll()
            {
                Random roll = new Random();
                damage = roll.Next(minRoll, maxRoll + 1);
                return damage;
            }
        }
        public class Maze : Weapon
        {
            int minRoll = 0;
            int maxRoll = 8;
            int damage = 0;
            internal override int Hit()
            {
                damage = Roll();
                Console.WriteLine("You hit the moster with the sword, it makes " + damage + " damage!");
                return damage;
            }
            internal override int Roll()
            {
                Random roll = new Random();
                damage = roll.Next(minRoll, maxRoll + 1);
                return damage;
            }
        }
    }
}
