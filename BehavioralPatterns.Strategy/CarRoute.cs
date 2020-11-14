using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralPatterns.Strategy
{
    public class CarRoute : IRoutePlanningStrategy
    {
        public string planningBestRoute(string origin, string destiny)
        {
            return "This is the best route to go from "+origin+" to "+destiny+ " by car.";
        }
    }
}
