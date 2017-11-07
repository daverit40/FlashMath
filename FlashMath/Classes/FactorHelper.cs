using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlashMath.Classes
{
    public static class FactorHelper
    {
        public static Factors generateFactors(gameDificulty difficulty, int factFamily)
        {
            int yLimit = 0;
            Factors factors = new Factors();

            switch (difficulty)
            {
                case gameDificulty.easy:
                    yLimit = 4;
                    break;
                case gameDificulty.medium:
                    yLimit = 8;
                    break;
                case gameDificulty.hard:
                    yLimit = 12;
                    break;
            }

            //generate random number up to yLimit;
            factors.y = new Random().Next(0, yLimit);
            factors.x = factFamily;

            return factors;
                    
        }
    }



    public enum gameDificulty
    {
        easy,
        medium,
        hard
    }
}