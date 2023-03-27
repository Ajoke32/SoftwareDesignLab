using PatternsPartTwo.Decorator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPartTwo.Decorator.Items
{
    internal class Staff : BaseHeroSet, Iitem
    {
        public Staff(Hero hero) : base(hero)
        {
            Damage += 40;
        }
       
        public string Description()
        {
            return "+40 to damage, +20 to hero weight";
        }

        public override int GetArmor()
        {
            return _hero.GetArmor() + 2;
        }

        public override int GetDamage()
        {
            return _hero.GetDamage() + Damage;
        }

        public override int GetHitPoints()
        {
            return _hero.HitPoints + 2;
        }
    }
}
