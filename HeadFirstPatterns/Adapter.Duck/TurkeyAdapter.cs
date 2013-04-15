using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.Adapter.Duck
{
    class TurkeyAdapter : IDuck
    {
        WildTurkey turkey;

        public TurkeyAdapter(WildTurkey turkey)
        {
            this.turkey = turkey;
        }

        #region IDuck Members

        public void quack()
        {
            turkey.gobble();
        }

        public void fly()
        {
            for (int i = 0; i < 5; i++)
            {
                turkey.fly();
            }
        }

        #endregion
    }
}
