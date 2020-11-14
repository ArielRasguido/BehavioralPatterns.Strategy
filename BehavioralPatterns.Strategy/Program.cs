using System;

namespace BehavioralPatterns.Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            NavigationApp navigationApp = new NavigationApp();
            navigationApp.showMenu();
        }
    }
}