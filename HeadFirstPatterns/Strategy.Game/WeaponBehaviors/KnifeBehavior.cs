using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.Strategy.Game
{
    class KnifeBehavior : IWeaponBehavior
    {
        #region IWeaponBehavior Members

        public void UseWeapon()
        {
            Console.WriteLine("stabs with a knife");
        }

        #endregion
    }
}
