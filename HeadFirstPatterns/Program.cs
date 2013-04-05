﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeadFirstPatterns.Strategy.Duck;
using HeadFirstPatterns.Strategy.Game;
using HeadFirstPatterns.Observer.Weather;
using HeadFirstPatterns.Decorator.Beverage;
using HeadFirstPatterns.Factory.Pizza;
using HeadFirstPatterns.Singleton.Chocolate;
using HeadFirstPatterns.Command.RemoteControl;

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

            ChocolateBoiler b1 = ChocolateBoiler.ChocolateBoilerInstance;
            ChocolateBoiler b2 = ChocolateBoiler.ChocolateBoilerInstance;

            b1.fill();
            b2.fill();
            b1.boil();
            b1.drain();
            b2.boil();
            b2.drain();

            Console.WriteLine();

            SimpleRemoteControl remote = new SimpleRemoteControl();
            Light light = new Light("Light");
            LightOnCommand lightOn = new LightOnCommand(light);
            GarageDoor door = new GarageDoor("Garage Door");
            GarageDoorOpenCommand doorOpen = new GarageDoorOpenCommand(door);

            light.getStatus();
            remote.setCommand(lightOn);
            remote.buttonWasPressed();
            light.getStatus();
            door.getStatus();
            remote.setCommand(doorOpen);
            remote.buttonWasPressed();
            door.getStatus();

            Console.WriteLine();

            RemoteControl rc = new RemoteControl();

            Light livingRoomLight = new Light("Living Room Light");
            Light kitchenLight = new Light("Kitchen Light");
            GarageDoor garageDoor = new GarageDoor("Garage Door");
            Stereo stereo = new Stereo("Stereo");

            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);
            LightOnCommand kitchenLightOn = new LightOnCommand(kitchenLight);
            LightOffCommand kitchenLightOff = new LightOffCommand(kitchenLight);

            GarageDoorOpenCommand garageDoorUp = new GarageDoorOpenCommand(garageDoor);
            GarageDoorDownCommand garageDoorDown = new GarageDoorDownCommand(garageDoor);

            StereoOnWithCDCommand stereoOnWithCD = new StereoOnWithCDCommand(stereo);
            StereoOffCommand stereoOffCommand = new StereoOffCommand(stereo);

            rc.setCommand(0, livingRoomLightOn, livingRoomLightOff);
            rc.setCommand(1, kitchenLightOn, kitchenLightOff);
            rc.setCommand(2, stereoOnWithCD, stereoOffCommand);
            
            Console.WriteLine(rc.toString());

            rc.onButtonWasPushed(0);
            rc.offButtonWasPushed(0);
            rc.onButtonWasPushed(1);
            rc.offButtonWasPushed(1);
            rc.onButtonWasPushed(2);
            rc.offButtonWasPushed(2);

            Console.WriteLine();

            Console.WriteLine("Press the 'Any' Key...");
            Console.ReadLine();
        }
    }
}
