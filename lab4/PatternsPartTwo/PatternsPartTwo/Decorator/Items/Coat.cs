using PatternsPartTwo.Decorator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPartTwo.Decorator.Items
{
    internal class Coat : Iitem
    {
        public string Name => "Coat";

        public void Description()
        {
            Console.WriteLine("Protection:5, wage:10");
        }
    }
}
