using PaternsImpl.AbsctractFactoryMethod.Interfaces;
using PaternsImpl.AbsctractFactoryMethod.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternsImpl.AbsctractFactoryMethod.Factories
{
    internal class WomansClotherFactory : IClothesFactory
    {
        public ISocks CreateSocks()
        {
            return new WomanSocks();
        }

        public ITrousers CreateTrousers()
        {
            return new WomanPants() { TissueType="LG2R", PocketsNumber=12};
        }

        public ITShirt CreateTShirt()
        {
            return new WomanTshit();
        }
    }
}
