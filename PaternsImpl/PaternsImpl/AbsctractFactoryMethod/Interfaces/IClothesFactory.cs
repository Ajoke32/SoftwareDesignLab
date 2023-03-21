using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternsImpl.AbsctractFactoryMethod.Interfaces
{
    internal interface IClothesFactory
    {
        public ITShirt CreateTShirt();

        public ITrousers CreateTrousers();

        public ISocks CreateSocks();
    }
}
