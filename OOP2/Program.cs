using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Engin Demirog -Gerçek müşteri
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.Adi = "Engin;";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "12555";

            //Kodlama.Io- Tüzel müşteri
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54236";
            musteri2.SirketAdi = "Kodlama.IO";
            musteri2.VergiNo = "1234568";


            //Gerçek Müşteri-Tüzel Müşteri
            //SOLID
            //bir yerde new görürsek bu bir referans nosudur. Musteri hem gerçek müşterinin hem de tüzel müşterinin adresini tutuyor.

            Musteri musteri3 = new GercekMusteri();

            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

        }
    }
}
