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

        public override int Attac()
        {
            return _hero.Attac()+Armor;
        }
        public string Description()
        {
            return "+5 to protection, +5 to hero weigth";
        }
    }
}
