using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> kisi = new MyDictionary<string, int>();
            kisi.Add(1, "hako");
            kisi.Add(2,"maho");
            kisi.Add(3,"samo");

            Console.WriteLine(kisi.Count);
        }
    }
}
