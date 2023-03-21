using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternsImpl.AbsctractFactoryMethod.Interfaces
{
    internal interface IClothes
    {
        public int Size { get; set; }

        public string BrandName { get; set; }

        public string Color { get; set; }

    }
}
