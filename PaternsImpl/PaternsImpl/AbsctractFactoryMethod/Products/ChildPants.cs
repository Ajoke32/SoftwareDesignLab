using PaternsImpl.AbsctractFactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternsImpl.AbsctractFactoryMethod.Products
{
    internal class ChildPants: ITrousers, IClothes
    {
        public int Size { get; set; }
        public string? BrandName { get; set; }
        public string? TissueType { get; set; }
        public int PocketsNumber { get; set; }
        public string? Color { get; set; }
    }
}
