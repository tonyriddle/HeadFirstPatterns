using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.Decorator.Beverage
{
    public class Soy : CondimentDecorator
    {
        Beverage beverage;

        public Soy(Beverage b)
        {
            beverage = b;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", Soy";
        }

        public override double cost()
        {
            return .15 + beverage.cost();
        }
    }
}
