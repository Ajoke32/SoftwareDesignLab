using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouseApp.Classes;
using WareHouseApp.Stores;
using WareHouseApp.Interfaces;

namespace WareHouseApp.Repositories
{
    internal class CategoryRepository : ICategoryRepository
    {
        private readonly Store _store;
        public CategoryRepository(Store store)
        {
            _store = store;
        }
        public void AddCategory(Category category)
        {
            _store.Categories.Add(category);
        }

        public void DeleteCategory(int id)
        {
            var searhedCategory = GetCategoryById(id);
            if (searhedCategory != null)
            {
                _store.Categories.Remove(searhedCategory);
            }
        }

        public List<Category> GetCategories()
        {
            return _store.Categories;
        }

        public Category? GetCategoryById(int id)
        {
            return _store.Categories.FirstOrDefault(c=>c.Id == id); 
        }

        public Category? GetCategoryByName(string name)
        {
            return _store.Categories.FirstOrDefault(c => c.Name == name);
        }

        public void UpdateCategory(int id, Category category)
        {
            var searhedCategory = GetCategoryById(id);
            if(searhedCategory != null)
            {
                searhedCategory = category;
            }
        }
    }
}
