using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            Product product = new Product {Id=2, CategoryId=5, ProductName = "kalem", UnitPrice= 35, UnitInStock = 5 };

            //PascalCase //camelCase
            //case sensitive 
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            

            // int, bool, double... değer tip 
            // diziler, class, abstract class, interface ... referans tip


        }
    }
}
