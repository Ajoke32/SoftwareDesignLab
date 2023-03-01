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
    internal class WareHouseManager : IWareHouseManager
    {
        // Single Responsibility Principle
        //ProductRepository відповідає тільки за роботу з продуктами, а генерацію звіту про продукт здійснює зовнішня служба.
        // WareHouseManager відповідає за роботу з продуктами, а ReportingService відповідає за генерацію звіту про продукт.
        private WareHouse _wareHouse;
        private IReportingService _reportingService;
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

            _reportingService.CreateReport(product, "The product has arrived at the warehouse");

        }

        public void AddProducts(List<Product> products)
        {
            foreach (Product product in products)
            {
                AddProduct(product);
                _reportingService.CreateReport(product, "The product has arrived at the warehouse");
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
                _reportingService.CreateReport(product, "The product has been exported",true);
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
