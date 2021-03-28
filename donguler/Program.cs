using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        { // i++ birer birer arttırmak 
          // for bir döngü türüdür
            string k1 = "yazılım geliştirme kampı";
            string k2 = "programlama başlangıç kursu";
            string k3 = "Java";

            //array-diziler
            // tek tek tanımlamak yerine liste içinde tanımlama yapılır
          string[] kurslar = new string[] { "yazılım geliştirme kampı", "programlama başlangıç kursu", "Java", "Java2" };

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(kurslar[i]); 
            }
            Console.WriteLine("forbitti");

            //kursları dolaş demek? dizilere uygulanır for yerine bu şekilde de yazılabilir
            foreach (string kurs in kurslar)
            {
                Console.WriteLine();
            }
        
        }
    }
}
