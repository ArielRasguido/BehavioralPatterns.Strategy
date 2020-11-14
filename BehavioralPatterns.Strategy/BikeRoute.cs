using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralPatterns.Strategy
{
    public class BikeRoute : IRoutePlanningStrategy
    {
        public void planningBestRoute(string origin, string destiny)
        {
            Console.WriteLine("This is the best route to go from " + origin + " to " + destiny + " by bike.");
        }
    }
}
