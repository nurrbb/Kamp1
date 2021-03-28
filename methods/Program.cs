using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunadi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] {"elma", "karpuz" };

            urun urun1 = new urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            urun urun2 = new urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakir karpuzu";

            //type-safe--tip güvenli
            urun[] urunler = new urun[] {urun1,urun2 };
            foreach (var
                urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------");
            }

            Console.WriteLine("-------------------Methodlar-----------------------");

            //instance
            //encaplution
            sepetmanager sepetmanager = new sepetmanager();
            sepetmanager.Ekle(urun1);
            sepetmanager.Ekle(urun2);
            sepetmanager.Ekle2("armut", "yeşil armut", 12,9);
            sepetmanager.Ekle2("elma", "yeşil elma", 12,6);
            sepetmanager.Ekle2("karpuz", "diyarbakır karpuzu", 12,8);


        }
    }
}
