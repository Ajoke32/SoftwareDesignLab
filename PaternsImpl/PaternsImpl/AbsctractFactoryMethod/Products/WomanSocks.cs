using PaternsImpl.AbsctractFactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternsImpl.AbsctractFactoryMethod.Products
{
    internal class WomanSocks : ISocks
    {
        public void GetColor()
        {
            Console.WriteLine("Pink");
        }

        public void GetSize()
        {
            Console.WriteLine("30");
        }

        public void GetTisuueType()
        {
            Console.WriteLine("LST1");
        }
    }
}
