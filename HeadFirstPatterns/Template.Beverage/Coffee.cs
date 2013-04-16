using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.Template.Beverage
{
    public class Coffee : CaffeineBeverage
    {
        public override void addCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }

        public override void brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }

        public override bool customerWantsCondiments()
        { 
            //book says to ask user, since I'm putting all tests in main, I don't want to pause, so just randomly decide to give condiments or not
            Random r = new Random();
            int i = r.Next(2);
            if (i == 0)
            {
                Console.WriteLine("No Condiments");
                return false;
            }
            else
            {
                Console.WriteLine("Give the man his stuff");
                return true;
            }
        }
    }
}
