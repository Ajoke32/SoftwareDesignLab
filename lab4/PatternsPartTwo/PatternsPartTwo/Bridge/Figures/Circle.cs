using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPartTwo.Bridge.Figures
{
    internal class Circle:Shape
    {
        public override string Name => "Circle";

        public override void Draw()
        {
            Console.Write($"Drawing {Name}");
        }
    }
}
