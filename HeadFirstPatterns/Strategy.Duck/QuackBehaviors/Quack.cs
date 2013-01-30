using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.Strategy.Duck
{
    class Quack : IQuackBehavior
    {
        #region IQuackBehavior Members

        public void quack()
        {
            Console.WriteLine("Quack");
        }

        #endregion
    }
}
