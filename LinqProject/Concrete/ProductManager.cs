using LinqProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq; 

namespace LinqProject.Concrete
{
    class ProductManager : IProduct
    {

        List<Product> _products;

        public ProductManager()
        {
            _products =new List<Product> { 
            
                new Product{ProductId=1,CategoryId=1,ProductName ="Acer Laptop", QuantityPerUnit="32 GB Ram",UnitPrice=10000 , UnitsInStock =5 },
                new Product{ProductId=2,CategoryId=1,ProductName ="Asus Laptop", QuantityPerUnit="16 GB Ram",UnitPrice=8000 , UnitsInStock =3 },
                new Product{ProductId=3,CategoryId=1,ProductName ="HP Laptop", QuantityPerUnit="8 GB Ram",UnitPrice=6000 , UnitsInStock =2 },
                new Product{ProductId=4,CategoryId=2,ProductName ="Samsun Telefon", QuantityPerUnit="4 GB Ram",UnitPrice=5000 , UnitsInStock =15 },
                new Product{ProductId=5,CategoryId=2,ProductName ="Apple Telefon", QuantityPerUnit="4 GB Ram",UnitPrice=8000 , UnitsInStock =0 }
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId == product.ProductId);
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.QuantityPerUnit = product.QuantityPerUnit;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock; 
        }
    }
}
