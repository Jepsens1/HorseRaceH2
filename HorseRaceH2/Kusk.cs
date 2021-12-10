using System;
using System.Collections.Generic;
using System.Text;

namespace HorseRaceH2
{
    class Kusk : IKusk
    { 
        //Checking if the horse is galoping, 5% chance
        //Returns a bool
        public bool IsGaloping(Random r)
        {
            if (r.Next(0,100) <= 5) 
            {
                return true;
            }
            return false;
        }
    }
}
