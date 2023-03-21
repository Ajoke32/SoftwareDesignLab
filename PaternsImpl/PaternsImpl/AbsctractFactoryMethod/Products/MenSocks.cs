using PaternsImpl.AbsctractFactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternsImpl.AbsctractFactoryMethod.Products
{
    internal class MenSocks : ISocks
    {
        public void GetColor()
        {
            Console.WriteLine("Black");
        }

        public void GetSize()
        {
            Console.WriteLine("LS");
        }

        public void GetTisuueType()
        {
            Console.WriteLine("B2L2");
        }
    }
}
