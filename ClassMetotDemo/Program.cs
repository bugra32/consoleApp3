using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.MusteriAd = "sümeyra";
            musteri1.MusteriSoyad = "g**";
            musteri1.Meslek = "işsiz";
            musteri1.Maas = 180;


            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.MusteriAd = "onur";
            musteri2.MusteriSoyad = "tek**";
            musteri2.Meslek = "pazarlamacı";
            musteri2.Maas = 3500;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.MusteriAd = "oğuz";
            musteri3.MusteriSoyad = "ice**";
            musteri3.Meslek = "öğrenci";
            musteri3.Maas = 100;


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (Musteri musteri  in musteriler)
            {
                Console.WriteLine("Müşterinin sırası : " + musteri.Id);
                Console.WriteLine("Müşterinin adı : "+musteri.MusteriAd);
                Console.WriteLine("Müşteri soyad : " + musteri.MusteriSoyad);
                Console.WriteLine("Müşteri meslek : " + musteri.Meslek);
                Console.WriteLine("Müşteri maas"+ musteri.Maas);

            }

            Console.WriteLine("---------------");


            MusteriYonetim musteriYonetim = new MusteriYonetim();
            musteriYonetim.Ekle(musteri2);
            musteriYonetim.Ekle(musteri1);
            Console.WriteLine("Müşterilerin maaş listesi");
            musteriYonetim.List(musteriler);
            musteriYonetim.Sil(musteri3);


            Console.WriteLine("Hello World!");
        }
    }
}
