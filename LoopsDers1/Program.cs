using System;

namespace LoopsDers1
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Yazılıma Giriş Kampı";
            string kurs3 = "Java Kampı";

            //array-dizi
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Yazılıma Giriş Kampı", "Java Kampı", "Python", "C++" };


            for (int i = 1; i <= 10; i++) //i=i+2 ya da i+=2 iki iki artar.
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti.");

            foreach (string kurs in kurslar) // dizi temelli yapıların tek tek dönmesine yarıyor.
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("sayfa sonu, footer");
        }
    }
}
