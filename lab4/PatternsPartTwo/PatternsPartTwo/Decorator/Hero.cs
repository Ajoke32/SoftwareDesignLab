using PatternsPartTwo.Decorator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPartTwo.Decorator
{
    internal abstract class Hero
    {
        public  int HitPoints { get; protected set; }

        public int Armor { get; protected set; }

        public int Damage { get; protected set; }

        public abstract int GetDamage();

        public abstract int GetArmor();

        public abstract int GetHitPoints();

        public  List<string> Inventory { get; protected set; }
    }
}
