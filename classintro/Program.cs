using System;

namespace classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            kurs kurs1 = new kurs();
            kurs1.Kursadi = "c#";
            kurs1.egitmen = "engindemirol";
            kurs1.izlenmeorani = 68;

            kurs kurs2 = new kurs();
            kurs2.Kursadi = "java";
            kurs2.egitmen = "kerem";
            kurs2.izlenmeorani = 34;

            kurs kurs3 = new kurs();
            kurs3.Kursadi = "pyhton";
            kurs3.egitmen = "berkay";
            kurs3.izlenmeorani = 98;


            Console.WriteLine(kurs1.Kursadi + "   " + kurs1.egitmen);
        }
    }
    
    // class içinde değişken oluşturuyoruz.
    class kurs
    {
        public string Kursadi { get; set; }
        public string egitmen { get; set; }
        public int izlenmeorani { get; set; }

    }
}
