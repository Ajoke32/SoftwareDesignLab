using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPartTwo.Bridge
{
    internal abstract class Shape
    {
        public abstract string Name { get; }

        public abstract void Draw();
        
    }
}
