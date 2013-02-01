using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.Factory.Pizza
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza createPizza(string item)
        {
            if (item.Equals("cheese"))
            {
                return new 
                    ChicagoStyleCheesePizza();
            }
            else if (item.Equals("pepperoni"))
            {
                return new ChicagoStylePepperoniPizza();
            }
            else if (item.Equals("clam"))
            {
                return new ChicagoStyleClamPizza();
            }
            else if (item.Equals("veggie"))
            {
                return new ChicagoStyleVeggiePizza();
            }
            else
            {
                return null;
            }
        }
    }
}
