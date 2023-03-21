using PaternsImpl.AbsctractFactoryMethod.Interfaces;
using PaternsImpl.AbsctractFactoryMethod.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternsImpl.AbsctractFactoryMethod.Factories
{
    internal class ChildClothesFactory : IClothesFactory
    {
        public ISocks CreateSocks()
        {
            return new ChildSocks();
        }

        public ITrousers CreateTrousers()
        {
            return new ChildPants();
        }

        public ITShirt CreateTShirt()
        {
            return new ChildTshirt();
        }
    }
}
