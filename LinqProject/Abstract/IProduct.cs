using LinqProject.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinqProject.Abstract
{
    public interface IProduct
    {
        public List<Product> GetAll() ;
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);


    }
}
