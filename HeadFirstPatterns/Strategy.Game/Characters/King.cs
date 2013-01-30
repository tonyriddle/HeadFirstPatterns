using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.Strategy.Game
{
    public class King : Character
    {
        public King()
        {
            SetWeaponBehavior(new SwordBehavior());
        }

        public King(IWeaponBehavior wb)
        {
            weaponBehavior = wb;
        }

        public override void fight()
        {
            Console.Write("The King ");
            weaponBehavior.UseWeapon();
        }
    }
}
