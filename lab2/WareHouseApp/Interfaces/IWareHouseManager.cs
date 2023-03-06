using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouseApp.Classes;

namespace WareHouseApp.Interfaces
{
    internal interface IWareHouseManager //interface segregation principle інтерфейси поділені на більш малі частини,  що відповідають за певний функціонал
    {
        //наприклад цей інтерфейс відповідає за роботу з продуктами на складі
        public void AddProduct(Product product);
        public void RemoveProduct(int id);
        public void UpadateProduct(Product updates,int id);
        public void AddProducts(List<Product> products);
        public Product? GetProductById(int id);
        public List<Product> GetAllProducts();

    }
}
