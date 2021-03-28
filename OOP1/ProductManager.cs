using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi. ");

        }
        public void Update(Product product) 
        {
            Console.WriteLine(product.ProductName + " güncellendi. ");
        }

        public int Topla(int Sayi1, int Sayi2)
        {
            return Sayi1 + Sayi2;

        }
        // çıktı int tipinde topla değeridir o sebeple çıktıyı kullanabiliriz!

        public void Topla2(int Sayi1, int Sayi2)
        {
            Console.WriteLine(Sayi1 + Sayi2);
        }
        // voidde komut çalıştırıldıktan sonra çıktı ile işlem yapmak mümkün değildir.!
    }
}
