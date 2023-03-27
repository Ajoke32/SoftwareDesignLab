using PatternsPartTwo.Decorator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPartTwo.Decorator.Heroes
{
    internal class Palladin : Hero
    {
        public override int GetArmor()
        {
            return Armor += 6;
        }

        public override int GetDamage()
        {
            return Damage += 2;
        }

        public override int GetHitPoints()
        {
            return HitPoints += 7;
        }
    }
}
