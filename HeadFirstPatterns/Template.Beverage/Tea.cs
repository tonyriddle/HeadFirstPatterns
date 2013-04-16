using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.Template.Beverage
{
    public class Tea : CaffeineBeverage
    {

        public override void addCondiments()
        {
            Console.WriteLine("Adding Lemon");
        }

        public override void brew()
        {
            Console.WriteLine("Steeping the Tea");
        }
    }
}
