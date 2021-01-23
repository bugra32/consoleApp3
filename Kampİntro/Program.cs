using System;

namespace Kampİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety = tip güvenliği 
            //Do not repeat yourself = kendini tekrar etme
            // kategoriEtiketi bir değer tutucu yani alias
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true ;
            double dolarınBugün = 7.45;
            double dolarınDün = 7.35;
            string artıs = "artış oku";
            string esit = "eşittrir";
            string azalıs = "azalış oku";

            if (dolarınDün>dolarınBugün)
            {
                Console.WriteLine(azalıs);
            }
            else if (dolarınBugün>dolarınDün)
            {
                Console.WriteLine(artıs);
            }
            else
            {
                Console.WriteLine(esit);
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
            
        }
    }
}
