using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    //Her bu interface içerende bunlar olmalı
    interface IKrediManager
    {
        //her kredinin hesaplanış şekli farklı bu yüzden class ı interface yaptık
        void Hesapla();
        void BiseyYap();
        //İnterfaceleri, birbirinin alterntifi olan ama kod içerikleri farklı olan durumlar için kullanırız.

    }
}
