using PatternsPartTwo.Decorator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPartTwo.Decorator.Items
{
    internal class MagicBall : BaseHeroSet,Iitem
    {

        public MagicBall(Hero hero) : base(hero)
        {
            Damage += 10;
            Inventory.Add(Description());
        }


        public override int Attac()
        {
            return Damage;
        }

        public string Description()
        {
            return "+10 to damage, +5 to magic power, type: attac by area";
        }
    }

}
