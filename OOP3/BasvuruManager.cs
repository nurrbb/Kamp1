using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService) // parantezin içine yazılan tüm hepsinin referansı olduğu için
        {
            // KonutKrediManager konutKrediManager = new KonutKrediManager();
            // konutKrediManager.Hesapla();
            // bu tarz bir yazılımda tüm başvurular konut kredisine bağlı halde gelir.!!

            krediManager.Hesapla();
            loggerService.log();

        }
       
        public void KrediOnBilgiledirmesiYap(List<IKrediManager> krediler)
            // bu bir eylemdir bunun içine yapması gerekenleri yazıyoruz
        {

            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        
        }


    }
}
