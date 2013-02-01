using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.Factory.Pizza
{
    public class ChicagoStyleVeggiePizza : Pizza
    {
        public ChicagoStyleVeggiePizza()
        {
            name = "Chicago Style Deep Dish Veggie Pizza";
            dough = "Extra Thick Crust Dough";
            sauce = "Plum Tomato Sauce";

            toppings.Add("Shredded Mozzarella Cheese");
            toppings.Add("Eggplant");
            toppings.Add("Spinach");
            toppings.Add("Black Olives");
        }

        public override void bake()
        {
            Console.WriteLine("Bake for 30 minutes at 325");
        }

        public override void cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}
