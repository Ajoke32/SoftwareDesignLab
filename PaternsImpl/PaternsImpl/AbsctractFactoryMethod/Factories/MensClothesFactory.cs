using PaternsImpl.AbsctractFactoryMethod.Interfaces;
using PaternsImpl.AbsctractFactoryMethod.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternsImpl.AbsctractFactoryMethod.Factories
{
    internal class MensClothesFactory : IClothesFactory
    {
        public ISocks CreateSocks()
        {
            return new MenSocks();
        }

        public ITrousers CreateTrousers()
        {
            return new MenPants() { BrandName = "Gucci",Color="Red", PocketsNumber=4,Size=15,TissueType="A1_RL"};
        }

        public ITShirt CreateTShirt()
        {
            return new MenTShirt();
        }
    }
}
