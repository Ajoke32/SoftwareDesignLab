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

        public override int Attac()
        {
            return _hero.Attac()+Damage;
        }
        public string Description()
        {
            return "+30 to damage, +40 to hero wage";
        }
    }
}
