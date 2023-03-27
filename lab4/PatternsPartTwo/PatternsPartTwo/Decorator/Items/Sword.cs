using PatternsPartTwo.Decorator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPartTwo.Decorator.Items
{
    internal class Sword : BaseHeroSet,Iitem
    {

        public Sword(Hero hero):base(hero)
        {
            Damage += 30;
            Inventory.Add(Description());
        }


        public string Description()
        {
            return "+30 to damage, +40 to hero wage";
        }

        public override int GetArmor()
        {
            return _hero.GetArmor();
        }

        public override int GetDamage()
        {
            return _hero.GetDamage()+Damage;
        }

        public override int GetHitPoints()
        {
            return _hero.GetHitPoints();
        }
    }
}
