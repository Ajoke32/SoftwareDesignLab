using PaternsImpl.AbsctractFactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternsImpl.AbsctractFactoryMethod.Products
{
    internal class ChildSocks : ISocks
    {
        public void GetColor()
        {
            Console.WriteLine("Green");
        }

        public void GetSize()
        {
            Console.WriteLine("10");
        }

        public void GetTisuueType()
        {
            Console.WriteLine("BR4");
        }
    }
}
