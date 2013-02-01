using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.Factory.Pizza
{
    public class NYStyleVeggiePizza : Pizza
    {
        public NYStyleVeggiePizza()
        {
            name = "NY Style Sauce and Veggie Pizza";
            dough = "Thin Crust Dough";
            sauce = "Marinara Sauce";

            toppings.Add("Grated Reggiano Cheese");
            toppings.Add("Mushrooms");
            toppings.Add("Onions");
            toppings.Add("Red Peppers");
        }
    }
}
