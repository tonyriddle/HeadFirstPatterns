using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.Adapter.Duck
{
    public class WildTurkey : ITurkey
    {
        #region ITurkey Members

        public void gobble()
        {
            Console.WriteLine("Gobble gobble");
        }

        public void fly()
        {
            Console.WriteLine("I'm flying all turkey like...");
        }

        #endregion
    }
}
