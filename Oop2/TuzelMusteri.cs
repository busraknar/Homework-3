using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop2
{   //Coorporate
    //miras- inheritance -> :Musteri
    //Musteri de olan herşey tüzel müşteride de kabul edilir
    internal class TuzelMusteri:Musteri
    {
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
