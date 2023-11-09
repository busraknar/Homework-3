using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class BasvuruManager
    {
        //Hangi krediyi istiyorsa hepsinin verisini tutan IKrediManager tanımlanır
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            //Başvuran bilgilerini değerlendirme
            krediManager.Hesapla();
            loggerService.Log();
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)  //veri türü IKrediManager
        {
            //Aynı veri türünde 1 de 1000de taşıyacak yapı;
            foreach ( var kredi in krediler)
            {
                kredi.Hesapla();
            }
        
        
        }
    }
}
