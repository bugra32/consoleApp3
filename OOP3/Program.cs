using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*IhtiyacKrediManager*/IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();
            IKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            ILoggerService dataBaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileBaseLoggerService = new FilebaseLoggerService();


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager,fileBaseLoggerService); 


            List<IKrediManager> krediler = new List<IKrediManager>() { konutKrediManager, tasitKrediManager};

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);




        }
    }
}
