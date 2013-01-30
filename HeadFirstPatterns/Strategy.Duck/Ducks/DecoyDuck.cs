using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.Strategy.Duck
{
    class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            flyBehavior = new NoFly();
            quackBehavior = new NoSound();
        }

        public override void display()
        {
            Console.WriteLine("I'm a decoy");
        }
    }
}
