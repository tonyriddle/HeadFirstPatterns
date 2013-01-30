using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstPatterns.Strategy.Game
{
    public class Queen : Character
    {
        public Queen()
        {
            SetWeaponBehavior(new KnifeBehavior());
        }

        public Queen(IWeaponBehavior wb)
        {
            weaponBehavior = wb;
        }

        public override void fight()
        {
            Console.Write("The Queen ");
            weaponBehavior.UseWeapon();
        }
    }
}
