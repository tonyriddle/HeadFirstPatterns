using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.Factory.Pizza
{
    public abstract class Pizza
    {
        public String name;
        public String dough;
        public String sauce;
        public List<String> toppings = new List<String>();

        public void prepare()
        {
            Console.WriteLine("Preparing " + name);
            Console.WriteLine("Tossing dough... " + dough);
            Console.WriteLine("Adding sauce... " + sauce);
            foreach (string topping in toppings)
            {
                Console.WriteLine("Adding topping... " + topping.ToString());
            }

            Console.WriteLine();
        }

        public virtual void bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public virtual void cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public virtual void box()
        {
            Console.WriteLine("Place pizza in the official PizzaStore box");
        }

        public virtual String getName()
        {
            return name;
        }
    }
}
