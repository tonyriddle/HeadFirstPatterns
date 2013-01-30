using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.Strategy.Duck
{
    class FlyRocketPowered : IFlyBehavior
    {
        #region IFlyBehavior Members

        public void fly()
        {
            Console.WriteLine("I'm flying with rockets");
        }

        #endregion
    }
}
