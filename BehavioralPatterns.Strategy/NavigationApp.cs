using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralPatterns.Strategy
{
    public class NavigationApp
    {
        RoutePlanner routePlanner;

        public NavigationApp()
        {
            routePlanner = new RoutePlanner();
        }

        public void showMenu()
        {
            int option=-1;
            do
            {
                Console.WriteLine("-----------Navigation app (Route Planner Menu)---------");
                Console.WriteLine("1. Set Origin and Destiny");
                Console.WriteLine("2. See the best Walk Route");
                Console.WriteLine("3. See the best Bicycle Route");
                Console.WriteLine("4. See the best Car Route");
                Console.WriteLine("0. Salir");
                Console.Write("\nPlease choose an option:");
                option = Convert.ToInt16(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        setOriginDestiny();
                        break;
                    case 2:
                        caculateBestRoute(new WalkRoute());
                        break;
                    case 3:
                        caculateBestRoute(new BikeRoute());
                        break;
                    case 4:
                        caculateBestRoute(new CarRoute());
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Press a key to continue...");
                Console.ReadKey();
                Console.Clear();
            } while (option!=0);
            
        }

        public void setOriginDestiny()
        {
            Console.Write("Set an origin:");
            routePlanner.Origin = Console.ReadLine();
            Console.Write("Set a destiny:");
            routePlanner.Destiny = Console.ReadLine();

        }

        public void caculateBestRoute(IRoutePlanningStrategy strategy)
        {
            if(routePlanner.Origin!=null && routePlanner.Origin != null)
            {
                routePlanner.SetRouteStrategy(strategy);
                routePlanner.CalculateRoute();
            }
            else
            {
                Console.WriteLine("Please set the origin and destiny first.");
            }
        }

    }
}
