using System;

namespace KampWork
{
    class Program
    {
        static void Main(string[] args)

        {

            Product urun1 = new Product();
            urun1.kategori = "İş bilgisayarı";
            urun1.model = "Huma h4 v3.1.2.";
            urun1.islemci = "intel i7-1051U";
            urun1.ram = 8;
            urun1.hafıza = 256;
            urun1.hafızaKategori = "SSD";
            urun1.fiyat = 7899;

            Product urun2 = new Product();
            urun2.kategori = "İş bilgisayarı";
            urun2.model = "Huma h5 v3.1.2.";
            urun2.islemci = "intel i7-1051U";
            urun2.ram = 16;
            urun2.hafıza = 556;
            urun2.hafızaKategori = "SSD";
            urun2.fiyat = 8999;


            Product urun3 = new Product();
            urun3.kategori = "İş bilgisayarı";
            urun3.model = "Huma h5 v1.1.2.";
            urun3.islemci = "intel i5-1051H";
            urun3.ram = 32;
            urun3.hafıza = 556;
            urun3.hafızaKategori = "SSD";
            urun3.fiyat = 10000;


            Product urun4 = new Product();
            urun4.kategori = "İş bilgisayarı";
            urun4.model = "Huma h5 v3.1.2.";
            urun4.islemci = "intel i7-1051U";
            urun4.ram = 16;
            urun4.hafıza = 1000;
            urun4.hafızaKategori = "SSD";
            urun4.fiyat = 1500;




            Product[] urunler = new Product[] { urun1, urun2, urun3, urun4 };
           
            

            Console.WriteLine("foreach döngüsü başlangıcı");

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.kategori+":" + urun.model + ":"+ urun.islemci+":"+ urun.ram+":"+urun.hafıza+":"+urun.hafızaKategori+":"+urun.fiyat);
            }

            Console.WriteLine("while döngüsü başlangıcı");

            int u = 0;

            while (u<urunler.Length)
            {
                Console.WriteLine("Kategori adı: " + urunler[u].kategori);
                Console.WriteLine("Model: " + urunler[u].model);
                Console.WriteLine("işlemci : " + urunler[u].islemci);
                Console.WriteLine("Ram (GB) : " + urunler[u].ram);
                Console.WriteLine("Hafıza (GB) : " + urunler[u].hafıza);
                Console.WriteLine("Hafıza kategori :" + urunler[u].hafızaKategori);
                Console.WriteLine("Fiyat :" + urunler[u].fiyat);
                u++;
            }

            Console.WriteLine("for döngüsü başlangıcı");
            for (var i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].kategori+" "+ urunler[i].model+" "+ urunler[i].ram+" "+urunler[i].hafıza+" "+urunler[i].hafızaKategori+" "+urunler[i].fiyat);
            }





            Console.WriteLine("Ödev bitiş");
        }
    }

    class Product
    {
        public string kategori { get; set; }

        public string  model { get; set; }

        public string islemci { get; set; }

        public int  ram { get; set; }

        public int  hafıza { get; set; }

        public string  hafızaKategori { get; set; }

        public int fiyat { get; set; }

    }
}
