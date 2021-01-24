using OOP1;
using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsStock = 3;


            Product product2 = new Product 
            { Id = 5, CategoryId = 2, 
                ProductName = "Bilgisayar", UnitsStock = 5, UnitPrice = 500 };

            ProductManagercs productManager = new ProductManagercs();
            productManager.Add(product2);




        }
    }
}
