using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //coorporate-tuzel, implementation- uygulama, entity- varlık
    //miras - inheritance, tuzel müşteri bir müşteridir.
    class TuzelMusteri:Musteri
    {
       
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
