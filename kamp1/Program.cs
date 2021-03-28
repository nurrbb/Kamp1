using System;

namespace kamp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety - tip güvenliği ksc: değişken tanımlanmadan önce türünün belirlenmesi
            // her satırdan sonra noktalı virgül koymayı unutma!
            // DO NOT REPEAT YOURSELF!!
            // kategori etiketi: Değer tutucu yani 'alias'

            string kategoriEtiketi = "Kategori";
            int ogrencisayisi = 32000;
            double faizOrani = 1.45;
            bool giris = false;
            double dolardun = 7.45;
            double dolarbugun = 7.55;

            //if yazdıktan sonra taba çift tıklandığında parantezler otomatik çıkıyor
            if (dolardun>dolarbugun)
            {
                Console.WriteLine("azalış butonu göster");
            }

            else if (dolardun<dolarbugun)
            {
                Console.WriteLine("artış butonu göster");
            }

            else
            {
                Console.WriteLine("sabit kaldı butonu");
            }


            if (giris == true)
            {
                Console.WriteLine("Kullanıcı ayarlar butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
}
      
         }
    }

