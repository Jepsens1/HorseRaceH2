using System;
using System.Collections.Generic;
using System.Text;

namespace HorseRaceH2
{
    class Horse : ITrav
    {
        //Properties
        public int NumberSign { get; private set; }
        public int HeadNumber { get; private set; }
        public string Color { get; private set; }
        public int Speed { get; private set; }
        public Sulky Sulky { get; private set; }

        Random random = new Random(Guid.NewGuid().GetHashCode());
        public Horse(int numbersign)
        {
            NumberSign = numbersign;
            Sulky = new Sulky();
        }
        //Trav method, first check to see if horse is in galop, if false return speed
        public int Trav()
        {
            if (!Sulky.Kusk.IsGaloping(random))
            {
                Speed = random.Next(50, 65);
                return Speed;
            }
            return 0;
        }

    }
}
