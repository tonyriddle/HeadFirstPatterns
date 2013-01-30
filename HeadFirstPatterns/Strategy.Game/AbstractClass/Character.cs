using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.Strategy.Game
{
    public abstract class Character
    {
        public IWeaponBehavior weaponBehavior;

        public abstract void fight();

        public void SetWeaponBehavior(IWeaponBehavior wb)
        {
            weaponBehavior = wb;
        }

    }
}
