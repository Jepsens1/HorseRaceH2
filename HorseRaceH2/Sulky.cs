using System;
using System.Collections.Generic;
using System.Text;

namespace HorseRaceH2
{
    class Sulky
    {
        //Properties
        public string[] Material { get; private set; }

        public Kusk Kusk { get; private set; }

        public Sulky()
        {
            Material = new string[] { "LightMetal, CarbonFiber" };
            Kusk = new Kusk();
        }
    }
}
