using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.Strategy.Duck
{
    class NoSound : IQuackBehavior
    {
        #region IQuackBehavior Members

        public void quack()
        {
            Console.WriteLine("Silence...");
        }

        #endregion
    }
}
