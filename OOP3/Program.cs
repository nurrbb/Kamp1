using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            İhtiyacKrediManager ihtiyacKrediManager = new İhtiyacKrediManager(); //yerine ikredimanager yazılsa da aynı sonuç alınır.
            //ihtiyacKrediManager.Hesapla();

            TasitKrediManager tasitKrediManager = new TasitKrediManager();
           // tasitKrediManager.Hesapla();

            KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(); bu şekilde yazıldığında parantez içine kredi tipini isteyeceği bir uyarı çıkıyor
            //kredi tipi gönderildikten sonra hesaplanan durum 
            basvuruManager.BasvuruYap(new EsnafKredisiManager, new SmsLoggerService());

            List<IKrediManager> krediler = new List<IKrediManager> {ihtiyacKrediManager };
            //basvuruManager.KrediOnBilgiledirmesiYap(krediler);



        }
    }
}
