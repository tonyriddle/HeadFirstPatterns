using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.Composite.Menu
{
    public class MenuItem : MenuComponent
    {
        String name;
        String description;
        bool vegetarian;
        double price;

        public MenuItem(String name, String description, bool vegetarian, double price)
        {
            this.name = name;
            this.description = description;
            this.vegetarian = vegetarian;
            this.price = price;
        }

        public override String getName()
        {
            return name;
        }

        public override String getDescription()
        {
            return description;
        }

        public override double getPrice()
        {
            return price;
        }

        public override bool isVegetarian()
        {
            return vegetarian;
        }

        public override void print()
        {
            Console.Write("   " + getName());
            if (isVegetarian())
            {
                Console.Write("(v)");
            }
            Console.WriteLine(", " + getPrice() + "   --" + getDescription());
        }
    }
}
