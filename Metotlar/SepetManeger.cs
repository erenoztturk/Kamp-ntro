using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManeger
    {
        // naming convention
        public void Ekle(Urun urun) 
        {

            Console.WriteLine(" tebrikler sepete eklendi!! " + urun.Adi, urun.Fiyat, urun.StokAdedi, urun.StokAdedi );
        }
        
        public void Ekle2(string urunAdi, string aciklama, double fiayt, int st)
        {
            Console.WriteLine(" tebrikler sepete eklendi!! " + urunAdi);
        }
    }
}
