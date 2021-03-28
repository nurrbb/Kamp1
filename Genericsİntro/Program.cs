using System;

namespace Genericsİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<String>();
            isimler.Add("Nur");

            Console.WriteLine(isimler.Length);
            isimler.Add("Gencer");
            Console.WriteLine(isimler.Length);

            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }

        }
    }
}
