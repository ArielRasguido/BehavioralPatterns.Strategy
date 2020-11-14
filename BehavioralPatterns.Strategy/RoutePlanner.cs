using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralPatterns.Strategy
{
    public class RoutePlanner
    {
        public string Origin { get; set; }
        public string Destiny { get; set; }

        private IRoutePlanningStrategy _routeStrategy;

        public void SetRouteStrategy(IRoutePlanningStrategy routeStrategy)
        {
            _routeStrategy = routeStrategy;
        }

        public void CalculateRoute()
        {
            _routeStrategy.planningBestRoute(Origin,Destiny);
        }
    }
}
