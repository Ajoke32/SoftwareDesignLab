using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouseApp.Classes;
using WareHouseApp.Interfaces;
using WareHouseApp.Stores;

namespace WareHouseApp.Managers
{
    internal class WareHouseManager : IWareHouseManager // Dependency Inversion Principle, клас залежить від інтерфейсу,
                                                        // а не від іншого класу або від функцій
    {
        // Single Responsibility Principle
        //ProductRepository відповідає тільки за роботу з продуктами, а генерацію звіту про продукт здійснює зовнішня служба(IReportingService)
        private WareHouse _wareHouse;
        private IReportingService _reportingService;

        // підстановка Лісков, тут можна передати іншу реалізацію репорт сервірсу і все буде працювати
        public WareHouseManager(WareHouse wareHouse, IReportingService reporting)
        {
            _wareHouse = wareHouse;
            _reportingService = reporting;
        }
        public void AddProduct(Product product)
        {
            var now = DateTime.Now;
            product.Arrivas = now;
            _wareHouse.Products.Add(product);

            _wareHouse.LastUpdate = now;
            //використовується один репорт
            _reportingService.CreateReport(new Report()
            {
                Id = Guid.NewGuid(),
                ProductInfo= product,
                IsDeleted= false,
                Description = "Product add to warehouse"
            });
        }

        public void AddProducts(List<Product> products)
        {
            foreach (Product product in products)
            {
                AddProduct(product);
                _reportingService.CreateReport(new Report()
                {
                    Id = Guid.NewGuid(),
                    ProductInfo = product,
                    IsDeleted = false,
                    Description = "Product add to warehouse"
                });
            }
        }

        public List<Product> GetAllProducts()
        {
            return _wareHouse.Products;
        }

        public Product? GetProductById(int id)
        {
            return _wareHouse.Products.FirstOrDefault(p => p.Id == id);
        }

        public void RemoveProduct(int id)
        {
            var product = GetProductById(id);
            if (product != null)
            {
                _wareHouse.Products.Remove(product);

                // також можна створити репорт іншого типу 
                _reportingService.CreateReport(new HTMLReport()
                {
                    Id = Guid.NewGuid(),
                    ProductInfo = product,
                    IsDeleted = true,
                    Description = "Product removed from warehouse"
                });

            }
        }

        public void UpadateProduct(Product updates,int id)
        {
           var product = GetProductById(id);
            if(product != null)
            {
                product = updates;
            }
        }
    }
}
