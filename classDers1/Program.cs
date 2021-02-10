using System;

namespace classDers1
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Delal";
            int yasi = 25;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "CSharp";
            kurs1.KursEgitmeni = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.KursEgitmeni = "Murat Altınok";
            kurs2.IzlenmeOrani = 75;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.KursEgitmeni = "Berfin Karakuş";
            kurs3.IzlenmeOrani = 55;

            //Console.WriteLine(kurs1.KursAdi + ":" + kurs1.KursEgitmeni);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3};
            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + ":" + kurs.KursEgitmeni);
            }

        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursEgitmeni { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
