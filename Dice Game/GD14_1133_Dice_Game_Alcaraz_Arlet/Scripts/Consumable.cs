using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace GD14_1133_Dice_Game_Alcaraz_Arlet.Scripts
{
    internal abstract class Consumable : Item
    {

        public class SmallPotion : Consumable //    All the potions are set here
        {
            int minRoll = 0;
            int maxRoll = 4;
            int hpRestored = 0;
            internal override int Used()
            {
                hpRestored = Roll();
                Console.WriteLine("You take the small potion and drink it in one sip, it restores " + hpRestored + " health!");
                return hpRestored;
            }
            internal override int Roll()
            {
                Random roll = new Random();
                hpRestored = roll.Next(minRoll, maxRoll + 1);
                return hpRestored;
            }
        }
        public class NormalPotion : Consumable
        {
            int minRoll = 0;
            int maxRoll = 6;
            int hpRestored = 0;
            internal override int Used()
            {
                hpRestored = Roll();
                Console.WriteLine("You take the normal potion and you drink it in 2 sips, it restores " + hpRestored + " health!");
                return hpRestored;
            }
            internal override int Roll()
            {
                Random roll = new Random();
                hpRestored = roll.Next(minRoll, maxRoll + 1);
                return hpRestored;
            }
        }
        public class LargePotion : Consumable
        {
            int minRoll = 0;
            int maxRoll = 8;
            int hpRestored = 0;
            internal override int Used()
            {
                hpRestored = Roll();
                Console.WriteLine("You take the large potion and drink it after a couple sips, it restores " + hpRestored + " health!");
                return hpRestored;
            }
            internal override int Roll()
            {
                Random roll = new Random();
                hpRestored = roll.Next(minRoll, maxRoll + 1);
                return hpRestored;
            }
        }
    }
}
