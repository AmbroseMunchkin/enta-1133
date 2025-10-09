using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GD14_1133_Dice_Game_Alcaraz_Arlet.Scripts
{
    internal class DieRoller
    {
        public int RollDice(int numFaces)
        {
            //roll random no. between 1 and numFaces + 1
            Random roll = new Random();
            return roll.Next(1, numFaces + 1);
        } 
    }
}