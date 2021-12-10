using System;
using System.Collections.Generic;
using System.Threading;

namespace HorseRaceH2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating 8 threads and starts method StartRace
            for (int i = 0; i < 8; i++)
            {
                Thread thread = new Thread(StartRace);
                thread.Start();;
            }
            Console.ReadKey();
        }
      static void StartRace()
        {
            //Creating a random to assign a random number to the horse
            Random random = new Random(Guid.NewGuid().GetHashCode());
            int number = random.Next(1, 10);
            RaceManager raceManager = new RaceManager(new Horse(number));
            Console.WriteLine(raceManager.Race(number));
        }
    }
}
