using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GD14_1133_Dice_Game_Alcaraz_Arlet.Scripts
{
    internal abstract class Item
    {
        public string Name { get; set; }
        internal abstract int Roll();
        internal abstract int Used();
    }
}
