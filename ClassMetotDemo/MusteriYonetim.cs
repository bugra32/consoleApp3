using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriYonetim
    {

        public void Ekle(Musteri musteri )
        {
            Console.WriteLine("Müşteri mesleği eklendi ");
            Console.WriteLine("meslek bilgisi " + musteri.Meslek);

        }

        public void Sil(Musteri musteri )
        {
            Console.WriteLine("Müşteri silindi ");
            Console.WriteLine(musteri.Id+ "Silindi ");
        } 

        public void List(Musteri[] musteriler ) 
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Maas+ "Tl");
            }
        }
    }
}
