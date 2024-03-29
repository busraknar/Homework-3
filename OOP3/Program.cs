﻿using System.Collections.Generic;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
           //ihtiyacKrediManager.Hesapla();

            IKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            IKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService= new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();
           
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), smsLoggerService);
            //basvuruManager.BasvuruYap( konutKrediManager, fileLoggerService);
            //basvuruManager.BasvuruYap(tasitKrediManager);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager , tasitKrediManager};
            basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        
        
        }  
    }
}