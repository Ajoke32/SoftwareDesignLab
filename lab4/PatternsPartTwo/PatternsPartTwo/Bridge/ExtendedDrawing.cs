using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPartTwo.Bridge
{
    internal class ExtendedDrawing : FigureDrawing
    {
        public ExtendedDrawing(Shape shape) : base(shape)
        {

        }

        public void ThreeDimensionalDrawing()
        {
            _shape.Draw();
            Console.WriteLine(" as 3D object");
        }
    }
}
