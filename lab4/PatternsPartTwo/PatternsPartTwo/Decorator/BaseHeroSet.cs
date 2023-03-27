using PatternsPartTwo.Decorator.Interface;
using PatternsPartTwo.Decorator.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPartTwo.Decorator
{
    internal abstract class BaseHeroSet : Hero
    {
        protected Hero _hero;
        public BaseHeroSet(Hero hero) : base()
        {
            _hero = hero;
            Inventory = new List<string>();
        }
    }
}
