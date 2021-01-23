using System;

namespace Classİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin Hoca";

            int yasi = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmeni = "Engin demiroğ";
            kurs1.IzlenmeOrani = 36;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Python";
            kurs2.Egitmeni = "Engin demiroğ";
            kurs2.IzlenmeOrani = 12;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Flutter";
            kurs3.Egitmeni = "Engin demiroğ";
            kurs3.IzlenmeOrani = 50;

            //Console.WriteLine(kurs1.KursAdi + " : "+ kurs1.Egitmeni  );
            Kurs[] kurslar = new Kurs[] {kurs1 , kurs2 , kurs3 };

            foreach (var kurs in kurslar) 
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmeni);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }

        public string Egitmeni { get; set; }

        public int IzlenmeOrani { get; set; }


    }

}
