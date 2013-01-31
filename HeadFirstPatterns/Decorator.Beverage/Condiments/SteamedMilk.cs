using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.Decorator.Beverage
{
    public class SteamedMilk : CondimentDecorator
    {
        Beverage beverage;

        public SteamedMilk(Beverage b)
        {
            beverage = b;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", Steamed Milk";
        }

        public override double cost()
        {
            return .10 + beverage.cost();
        }
    }
}
