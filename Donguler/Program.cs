using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım geliştirici yetiştirme kursu";
            string kurs2 = "Proglamlamaya başlangıç için temel kurs";
            string kurs3 = "java";

            // yukarıdaki verileri dizilerde tutarız = array

            string[] kurslar = new string[] {
                "Yazılım geliştirici yetiştirme kursu",
                "Proglamlamaya başlangıç için temel kurs",
                "java",
                "Python",
                "C#"
            };


            foreach (string  kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("forech bitii ");
             for (int i = 0; i< kurslar.Length; i++)
              {
                Console.WriteLine(kurslar[i]);
              }

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
