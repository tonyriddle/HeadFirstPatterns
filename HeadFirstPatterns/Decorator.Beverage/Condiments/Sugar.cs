using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.Decorator.Beverage
{
    public class Sugar : CondimentDecorator
    {
        Beverage beverage;

        public Sugar(Beverage b)
        {
            beverage = b;
        }
        public override string getDescription()
        {
            return beverage.getDescription() + ", Sugar";
        }

        public override double cost()
        {
            return beverage.cost() + .10;
        }
    }
}
