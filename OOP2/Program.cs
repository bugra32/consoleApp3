using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "124223";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "12343456";



            //Kodlamaa.io girisi tüzel musteri

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "12134566";
            musteri2.SirketAdi = "KOdlama.io";
            musteri2.VergiNo = "12357889";
        }
    }
}
