using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //miras inheritance extends(java) : tüzel müşteri bir müşteri dir demek oluyor
    class TuzelMusteri:Musteri
    {
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
