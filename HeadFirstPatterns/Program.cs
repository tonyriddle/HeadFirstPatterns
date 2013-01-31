using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeadFirstPatterns.Strategy.Duck;
using HeadFirstPatterns.Strategy.Game;
using HeadFirstPatterns.Observer.Weather;

namespace HeadFirstPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Design Patterns");

            Console.WriteLine();

            Console.WriteLine("Strategy Pattern:");

            Console.WriteLine();

            Duck mallard = new MallardDuck();
            mallard.performFly();
            mallard.performQuack();
            mallard.display();

            Console.WriteLine();

            Duck decoy = new DecoyDuck();
            decoy.performFly();
            decoy.setFlyBehavior(new FlyRocketPowered());
            decoy.performFly();
            decoy.performQuack();
            decoy.display();

            Console.WriteLine();

            Character queen = new Queen(new KnifeBehavior());
            queen.fight();

            Console.WriteLine();

            Character king = new King(new BowAndArrowBehavior());
            king.fight();

            Console.WriteLine();

            Console.WriteLine("Observer Pattern:");

            WeatherData wd = new WeatherData();
            CurrentConditionsDisplay cd = new CurrentConditionsDisplay(wd);
            AveragetemperatureDisplay ad = new AveragetemperatureDisplay(wd);
            cd.registerDisplay();
            ad.registerDisplay();
            wd.setMeasurements(70, 50, 10);
            wd.setMeasurements(80, 30, 5);
            wd.setMeasurements(95, 20, 1);
            cd.removeDisplay();
            wd.setMeasurements(50, 95, 50);
            wd.setMeasurements(32, 100, 65);
            ad.removeDisplay();

            Console.WriteLine("Press the 'Any' Key...");
            Console.ReadLine();
        }
    }
}
