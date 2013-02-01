using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeadFirstPatterns.Strategy.Duck;
using HeadFirstPatterns.Strategy.Game;
using HeadFirstPatterns.Observer.Weather;
using HeadFirstPatterns.Decorator.Beverage;
using HeadFirstPatterns.Factory.Pizza;

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

            Console.WriteLine();

            Beverage beverage = new Espresso();
            Console.WriteLine(beverage.getDescription() + " $" + beverage.cost());

            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine(beverage2.getDescription() + " $" + beverage2.cost());

            Beverage beverage3 = new HouseBlend();
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine(beverage3.getDescription() + " $" + beverage3.cost());

            Beverage beverage4 = new Decaf();
            beverage4 = new Sugar(beverage4);
            beverage4 = new Sugar(beverage4);
            Console.WriteLine(beverage4.getDescription() + " $" + beverage4.cost());

            Console.WriteLine();

            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();
            Pizza pizza = nyStore.orderPizza("cheese");
            Console.WriteLine("Customer1 ordered a " + pizza.getName());

            Console.WriteLine();

            pizza = chicagoStore.orderPizza("cheese");
            Console.WriteLine("Customer2 ordered a " + pizza.getName());

            Console.WriteLine();

            pizza = chicagoStore.orderPizza("veggie");
            Console.WriteLine("Customer3 ordered a " + pizza.getName());

            Console.WriteLine();

            Console.WriteLine("Press the 'Any' Key...");
            Console.ReadLine();
        }
    }
}
