﻿using System;

namespace Degervereferanstipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1=30
            Console.WriteLine(sayi1);
            int[] sayilar1 = new int[] {10, 20, 30};
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] = 999
            //sayısal veri tipleri: int,decimal,float,double,bool = değer tip!!
            //değer,class,interface = referans tip !!
            // bellekte stack ve heap adı verilen iki alan vardır stack:değer tip heap:referans tip
            //

        }
    }
}
