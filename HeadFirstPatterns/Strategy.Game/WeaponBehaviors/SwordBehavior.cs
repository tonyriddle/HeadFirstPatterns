using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.Strategy.Game
{
    class SwordBehavior : IWeaponBehavior
    {
        #region IWeaponBehavior Members

        public void UseWeapon()
        {
            Console.WriteLine("slices with a sword");
        }

        #endregion
    }
}
