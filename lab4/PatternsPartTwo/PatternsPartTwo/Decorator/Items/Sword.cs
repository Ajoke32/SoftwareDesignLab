using PatternsPartTwo.Decorator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPartTwo.Decorator.Items
{
    internal class Sword : Iitem
    {
        public string Name => "Sword";

        public void Description()
        {
            Console.WriteLine("Damage: 30, protection: 10, wage: 40");
        }
    }
}
