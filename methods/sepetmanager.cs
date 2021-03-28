using System;
using System.Collections.Generic;
using System.Text;

namespace methods
{
    class sepetmanager
    {
        //naming convention
        
        public void Ekle(urun urun) 
        {
            Console.WriteLine("teşekkürler, Sepete eklendi." + urun.Adi);


        }

        public void Ekle2(string urunadi, string aciklama, double fiyat, int stokadedi)
        {
            Console.WriteLine("teşekkürler, Sepete eklendi." + urunadi);
        }
    }
}
