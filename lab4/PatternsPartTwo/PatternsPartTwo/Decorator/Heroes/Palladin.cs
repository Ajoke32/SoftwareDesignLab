using PatternsPartTwo.Decorator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPartTwo.Decorator.Heroes
{
    internal class Palladin : Hero
    {


        public override int Attac()
        {
            return Damage += 5;
        }
    }
}
