using System;

namespace Genericsintro
{
    class Program
    {
        static void Main(string[] args)
        {
            //mylisti t bazında verdik istediğimiz türde olsun diye
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Engin");

            Console.WriteLine(isimler.Length);
            isimler.Add("hakko");

            Console.WriteLine(isimler.Length);
            isimler.Add("bugtra");

            Console.WriteLine(isimler.Length);


            Console.WriteLine("Hello World!");
        }
    }
}
