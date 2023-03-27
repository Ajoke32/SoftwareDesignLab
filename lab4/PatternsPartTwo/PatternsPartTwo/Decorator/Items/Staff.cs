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
        public override int Attac()
        {
            return Damage;
        }
        public string Description()
        {
            return "+40 to damage, +20 to hero weight";
        }
    }
}
