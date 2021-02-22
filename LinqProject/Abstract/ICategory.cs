using LinqProject.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinqProject.Abstract
{
    public interface ICategory
    {
        public List<Category> GetAll();
        void Add(Category product);
        void Update(Category product);
        void Delete(Category product);

    }
}
