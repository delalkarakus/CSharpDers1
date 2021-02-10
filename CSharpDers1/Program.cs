using System;

namespace CSharpDers1
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety-tip güvenliği
            //do not repeat yourself-kendini tekrarlama
            //değer tutucu- alias
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true; // sadece true ya da false ataması yapan bir veri tipidir.
            double dolarDun = 7.35;
            double dolarBugün = 7.45;

            if (dolarDun > dolarBugün)
            {
                Console.WriteLine("Artış Butonu");
            }
            else if (dolarDun < dolarBugün)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarı Butonu");

            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }


            Console.WriteLine("kategoriEtiketi");
        }

    }
}
