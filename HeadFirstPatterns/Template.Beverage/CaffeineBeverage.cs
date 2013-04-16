using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.Template.Beverage
{
    public abstract class CaffeineBeverage
    {
        public void prepareRecipe()
        {
            boilWater();
            brew();
            pourInCup();
            if (customerWantsCondiments())
            {
                addCondiments();
            }
        }

        public abstract void addCondiments();

        public void pourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        public abstract void brew();

        public void boilWater()
        {
            Console.WriteLine("Boiling Water");
        }

        public virtual bool customerWantsCondiments()
        {
            return true;
        }
    }
}
