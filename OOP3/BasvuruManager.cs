using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method injection yanı basvuru yap da hangi metodu kullanacağını ve hangi loglayıcı olacağını enjekte ediyoruz
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            krediManager.Hesapla();
            //aşvuranın bilgilerini değerlendire yaparız
            loggerService.Log();
        }


        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }

    }
}
