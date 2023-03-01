using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouseApp.Classes;

namespace WareHouseApp.Interfaces
{
    internal interface IWareHouseManager
    {
        public void AddProduct(Product product);
        public void RemoveProduct(int id);
        public void UpadateProduct(Product updates,int id);
        public void AddProducts(List<Product> products);
        public Product? GetProductById(int id);
        public List<Product> GetAllProducts();

    }
}
