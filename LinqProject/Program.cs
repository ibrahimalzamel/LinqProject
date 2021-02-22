using LinqProject.Concrete;
using System;
using System.Linq;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager products = new ProductManager();
            CategoryManager categorys = new CategoryManager();
            Satrted strated = new Satrted();

            //Console.WriteLine("=*=*=*=*=*=*=*=*= LİSTELE *=*=**==**==*=*\n");
            //strated.GetAll(products.GetAll());
            //products.Add(new Product { ProductId = 6, CategoryId = 2, ProductName = "S9+ Samsung", QuantityPerUnit = "6 GB Ram", UnitPrice = 5000, UnitsInStock = 3 });
            //Console.WriteLine("\n\n\n =*=*=*=*=*=*=*= Add *=*=*=**==**==*=*\n\n\n");
            //strated.GetAll(products.GetAll());
            //products.Delete(new Product { ProductId = 3, CategoryId = 1, ProductName = "HP Laptop", QuantityPerUnit = "8 GB Ram", UnitPrice = 6000, UnitsInStock = 2 });
            //Console.WriteLine("\n\n\n =*=*=*=*=*=*=*=*=*= Delete *=**==**==*=*\n\n\n");
            //strated.GetAll(products.GetAll());
            //products.Update(new Product { ProductId = 2, CategoryId = 2, ProductName = "Toshba Laptop", QuantityPerUnit = "16 GB Ram", UnitPrice = 5500, UnitsInStock = 5 });
            //Console.WriteLine("\n\n\n =*=*=*=*=*=*=*=*=* Update =*=**==**==*=*\n\n\n");
            //strated.GetAll(products.GetAll());

            //Console.WriteLine("\n\n\n =*=*=*=*=*=*=*=*=*=*=**==**==*=*\n\n");
            //Console.WriteLine("=*=*=*=*=*=*=*=*=*=*=**==**==*=*\n\n\n");

            //Console.WriteLine("\n=*=*=*=*=*=*=*=*= LİSTELE *=*=**==**==*=*\n");
            //strated.GetAllCategorey(categorys.GetAll());
            //categorys.Add(new Category {CategoryId=3,CategoryName="Tablet"});
            //Console.WriteLine("\n\n\n =*=*=*=*=*=*=*= Add *=*=*=**==**==*=*\n\n\n");
            //strated.GetAllCategorey(categorys.GetAll());
            //categorys.Delete(new Category {CategoryId = 3 , CategoryName = "Tablet" });
            //Console.WriteLine("\n\n\n =*=*=*=*=*=*=*=*=*= Delete *=**==**==*=*\n\n\n");
            //strated.GetAllCategorey(categorys.GetAll());
            //categorys.Update(new Category {CategoryId=1 ,CategoryName="ARABA"});
            //Console.WriteLine("\n\n\n =*=*=*=*=*=*=*=*=* Update =*=**==**==*=*\n\n\n");
            //strated.GetAllCategorey(categorys.GetAll());


            //LINQ  

            // AnyTest(products);

            // FindTest(products);

            // FindAllTest(products);

            // AscDescTest(products);
            // ClassicLinqMetot(products);
            JoinMetot(products, categorys);
        }

        private static void JoinMetot(ProductManager products, CategoryManager categorys)
        {
            var result = from p in products.GetAll()
                         join c in categorys.GetAll()//Join  İki listede ulaşan bir ozellik
                         on p.CategoryId equals c.CategoryId
                         where p.UnitPrice >5000
                         orderby p.UnitPrice descending
                         select new ProductDto
                         {
                             ProductId = p.ProductId,
                             CategoryName = c.CategoryName,
                             ProductName = p.ProductName,
                             UnitPrice = p.UnitPrice
                         };
            foreach (var productDto in result)
            {
                Console.WriteLine("{0}---{1}", productDto.ProductName, productDto.CategoryName);
            }
        }

        private static void ClassicLinqMetot(ProductManager products)
        {
            var result = from p in products.GetAll()
                         where p.UnitPrice > 6000 // && p.ProductName  where : Onu göre getir 
                         orderby p.UnitPrice descending, p.ProductName ascending    // orderby : onu göre Sırala
                         select p;               // P nin yaptik tüm İşlemlir getir ve result'e aktar
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void AscDescTest(ProductManager products)
        {
            //Singel Line query
            var result = products.GetAll().Where
                (p => p.ProductName.Contains("top")).OrderBy(
                p => p.UnitPrice).ThenByDescending(p => p.ProductName);

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void FindAllTest(ProductManager products)
        {
            //ProductName olan içinde "top" varsa listele
            var result = products.GetAll().FindAll(p => p.ProductName.Contains("top"));
            Console.WriteLine(result);
        }

        private static void FindTest(ProductManager products)
        {
            //ProductId olarak tum nesne getir
            var result = products.GetAll().Find(p => p.ProductId == 3);
            Console.WriteLine(result.ProductName);
        }

        private static void AnyTest(ProductManager products)
        {
            // ProductName Control Et  var mi yok mu ???  Any True Or False
            var result = products.GetAll().Any(p => p.ProductName == "Acer Laptop");
            Console.WriteLine(result);
            // ProductName Control Et  var mi yok mu ???  Any True Or False
            var result1 = products.GetAll().Any(p => p.ProductName == "AcerLaptop");
            Console.WriteLine(result1);
        }
    }

    class ProductDto {
        public int ProductId { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }

    }

}
