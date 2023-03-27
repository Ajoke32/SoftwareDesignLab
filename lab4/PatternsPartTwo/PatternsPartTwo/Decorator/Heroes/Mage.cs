using PatternsPartTwo.Decorator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPartTwo.Decorator.Heroes
{
    internal class Mage : Hero
    {
        public override string Name => "Mage";

        public override List<string> Inventory { get ; set; }

        public override void Attac()
        {
            Console.WriteLine("Mage attac");
        }
    }
}
