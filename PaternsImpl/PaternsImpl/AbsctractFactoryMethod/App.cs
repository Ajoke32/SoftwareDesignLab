using PaternsImpl.AbsctractFactoryMethod.Interfaces;
using PaternsImpl.AbsctractFactoryMethod.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternsImpl.AbsctractFactoryMethod
{
    internal class App
    {
        private IClothesFactory _factory;

        private ITShirt _tshirt;

        private ITrousers _trousers;

        private ISocks _socks;
        public App(IClothesFactory factory)
        {
            _factory= factory;
        }

        public void CreateTshirt()
        {
            _tshirt = _factory.CreateTShirt();
        }

        public void PrintTshirtInfo()
        {
            _tshirt.AboutProduct();
        }

        public void CreateTrousers()
        {
            _trousers= _factory.CreateTrousers();
        }

        public void PrintTrousersInfo()
        {
            Console.WriteLine($"Tissue type:{_trousers.TissueType}\nPockets number:{_trousers.PocketsNumber}");
        }

        public void CreateSocks()
        {
            _socks = _factory.CreateSocks();
        }

        public void PrintSocksInfo()
        {
            Console.Write("Color: ");
            _socks.GetColor();
            Console.WriteLine();
            Console.Write("Size: ");
            _socks.GetSize();
            Console.WriteLine();
            Console.Write("Tissue type: ");
            _socks.GetTisuueType();
            Console.WriteLine();
        }
        
    }
}
