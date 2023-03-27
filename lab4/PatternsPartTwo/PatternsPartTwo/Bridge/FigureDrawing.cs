using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPartTwo.Bridge
{
    internal class FigureDrawing
    {
        protected Shape _shape;
        
        public FigureDrawing(Shape shape)
        {
            _shape = shape;
        }

        public void RasterDrawing()
        {
            _shape.Draw();
            Console.Write($" as pixels\n");
        }

        public void VectorDrawing()
        {
            _shape.Draw();
            Console.Write(" as vector objects\n");
        }
    }
}
