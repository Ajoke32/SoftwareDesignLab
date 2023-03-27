using PatternsPartTwo.Decorator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPartTwo.Decorator.Items
{
    internal class Coat : BaseHeroSet, Iitem
    {
        public Coat(Hero hero) : base(hero)
        {
            Armor += 5;
            Inventory.Add(Description());
       
        }

        public override int GetDamage()
        {
            return _hero.GetDamage()+Damage;
        }
        public string Description()
        {
            return "+5 to protection, +5 to hero weigth";
        }

        public override int GetArmor()
        {
           return _hero.GetArmor()+Armor;
        }

        public override int GetHitPoints()
        {
            return _hero.GetHitPoints()+HitPoints/2;
        }
    }
}
