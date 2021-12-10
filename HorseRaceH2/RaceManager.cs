using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace HorseRaceH2
{
    class RaceManager
    {
        ITrav trav;
        //Distance to check if race is over
        private int distance = 0;
        //Stopwatch to take time on how long it took a horse to trav
        private Stopwatch stopwatch = new Stopwatch();
        public RaceManager(ITrav _trav)
        {
            trav = _trav;
        }
        public string Race(int number)
        {
            //Starts timer
            StartTime();
            //While race is not finished, trav
            while (!IsFinished())
            {
                distance += trav.Trav();
                Thread.Sleep(100);
            }
            //Returns which horse is finished and how long it took
            return $"Horse: {number} Finished in " + EndTime();
        }
        //Starts timer
        public void StartTime()
        {
            stopwatch.Start();
        }
        //Ends timer
        public string EndTime()
        {
            return stopwatch.Elapsed.ToString();
        }
        //Checks to see if distance has reached end, returns bool
        public bool IsFinished()
        {
            if (distance >= 2000)
            {
                return true;
            }
            return false;
        }
    }
}
