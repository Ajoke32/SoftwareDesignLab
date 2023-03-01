using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouseApp.Classes;

namespace WareHouseApp.Interfaces
{
    internal interface ICategoryRepository
    {
        public void AddCategory(Category category);

        public void UpdateCategory(int id,Category category);

        public Category? GetCategoryById(int id);
        public List<Category> GetCategories();
        
        public void DeleteCategory(int id);

        public Category? GetCategoryByName(string name);
     
    }
}
