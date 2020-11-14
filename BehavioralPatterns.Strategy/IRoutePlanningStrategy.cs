using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralPatterns.Strategy
{
    public interface IRoutePlanningStrategy
    {
        string planningBestRoute(string origin, string destiny);
    }
}
