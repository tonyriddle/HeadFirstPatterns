using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.Factory.Pizza
{
    public abstract class PizzaStore
    {
        public Pizza orderPizza(String type)
        {
            Pizza pizza;
            pizza = createPizza(type);

            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            return pizza;
        }
        protected abstract Pizza createPizza(String type);
    }
}
