﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeadFirstPatterns.Strategy.Duck;

namespace HeadFirstPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Design Patterns");

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

            Console.WriteLine("Press the 'Any' Key...");
            Console.ReadLine();
        }
    }
}
