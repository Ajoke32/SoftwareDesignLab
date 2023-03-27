using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPartTwo.Decorator
{
    internal abstract class Hero
    {
        public abstract string Name { get; }

        public abstract void Attac();

        public abstract List<string> Inventory { get; set; }
    }
}
