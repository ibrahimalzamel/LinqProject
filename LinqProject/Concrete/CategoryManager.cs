using LinqProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace LinqProject.Concrete
{
    class CategoryManager : ICategory
    {

        List<Category> _Categories;

        public CategoryManager()
        {
            _Categories = new List<Category>
            {
                new Category {CategoryId = 1 , CategoryName = "Bilgisayar"},
                new Category {CategoryId = 2 , CategoryName = "Telefon"}
            };
        }

        public void Add(Category category)
        {
            _Categories.Add(category);
        }

        public void Delete(Category category)
        {
           
          Category  categoryToDelet = _Categories.SingleOrDefault(c=>c.CategoryId == category.CategoryId);
            _Categories.Remove(categoryToDelet);
        }

        public List<Category> GetAll()
        {
            return _Categories; 
        }

        public void Update(Category category)
        {
            Category categoryToUpdate = _Categories.SingleOrDefault(c => c.CategoryId == category.CategoryId);
            categoryToUpdate.CategoryId = category.CategoryId;
            categoryToUpdate.CategoryName = category.CategoryName; 

        }
    }
}
