using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.Factory.Pizza
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza createPizza(string item)
        {
            if (item.Equals("cheese"))
            {
                return new NYStyleCheesePizza();
            }
            else if (item.Equals("pepperoni"))
            {
                return new NYStylePepperoniPizza();
            }
            else if (item.Equals("clam"))
            {
                return new NYStyleClamPizza();
            }
            else if (item.Equals("veggie"))
            {
                return new NYStyleVeggiePizza();
            }
            else
            {
                return null;
            }
        }
    }
}
