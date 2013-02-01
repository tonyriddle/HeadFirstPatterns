using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.Factory.Pizza
{
    public class NYStyleClamPizza : Pizza
    {
        public NYStyleClamPizza()
        {
            name = "NY Style Sauce and Clam Pizza";
            dough = "Thin Crust Dough";
            sauce = "Marinara Sauce";

            toppings.Add("Grated Reggiano Cheese");
            toppings.Add("Fresh Clams");
        }
    }
}
