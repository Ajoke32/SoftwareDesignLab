using PatternsPartTwo.Decorator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPartTwo.Decorator.Heroes
{
    internal class Warrior : Hero
    {


        public override int GetArmor()
        {
            return Damage += 3;
        }

        public override int GetHitPoints()
        {
            return HitPoints += 5;
        }

        public override int GetDamage()
        {
            return Damage += 3;
        }
    }
}
