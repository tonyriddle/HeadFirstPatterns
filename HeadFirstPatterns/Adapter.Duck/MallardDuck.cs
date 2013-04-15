using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.Adapter.Duck
{
    public class MallardDuck : IDuck
    {
        #region IDuck Members

        public void quack()
        {
            Console.WriteLine("Quack");
        }

        public void fly()
        {
            Console.WriteLine("I'm Flying... Like a duck.");
        }

        #endregion
    }
}
