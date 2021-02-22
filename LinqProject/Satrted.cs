using LinqProject.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinqProject
{
    public  class Satrted
    {
       
        public void GetAll (List<Product> Products)
        {

            foreach (var product in Products)
            {
                Console.WriteLine("ProductId : " + product.ProductId);
                Console.WriteLine("CategoryId : " + product.CategoryId);
                Console.WriteLine("ProductName : " + product.ProductName);
                Console.WriteLine("QuantityPerUnit : " + product.QuantityPerUnit);
                Console.WriteLine("UnitPrice : " + product.UnitPrice);
                Console.WriteLine("UnitsInStock : " + product.UnitsInStock);
                Console.WriteLine("=============================================");
            }
        }

        public void GetAllCategorey(List<Category> categories)
        {
            foreach (var category in categories)
            {
                Console.WriteLine("CategoryId : " + category.CategoryId);
                Console.WriteLine("CategoryName : " + category.CategoryName);
            }
        }
    }
}
