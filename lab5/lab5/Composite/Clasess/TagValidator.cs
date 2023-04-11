using lab5.Composite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Composite.Clasess
{
    internal static class TagValidator
    {
    
        public static bool IsAppendable(LightElementNode node)
        {
            return node.ClosureType==ClosureType.Patrial;
        }
        

    }
}
