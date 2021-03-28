using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ID = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInstock = 3;

            //veya şu şekilde de yazılabilir = 

            Product product2 = new Product { ID = 2, CategoryId = 5, UnitInstock = 5,
                ProductName = "Kalem", UnitPrice = 35 };

            ProductManager productManager = new ProductManager();
            
              

        }
    }
}
