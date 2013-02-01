using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.Factory.Pizza
{
    public class NYStylePepperoniPizza : Pizza
    {
        public NYStylePepperoniPizza()
        {
            name = "NY Style Sauce and Pepperoni Pizza";
            dough = "Thin Crust Dough";
            sauce = "Marinara Sauce";

            toppings.Add("Grated Reggiano Cheese");
            toppings.Add("Pepperoni");
        }
    }
}
