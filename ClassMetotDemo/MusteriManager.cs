using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(string musteriAdi, int musteriId, int musteriYasi, string musteriMemleketi, string musteriDurum) 
        {
            
            Console.WriteLine("Bankamıza Hoş Geldiniz Sayın ----->"+musteriAdi );
            Console.WriteLine("--BİLGİLERİNİZ--");
            Console.WriteLine("ID : " + musteriId);
            Console.WriteLine("YAŞ :" + musteriYasi);
            Console.WriteLine("MEMLEKET : " + musteriMemleketi);
            Console.WriteLine("MEDENİ DURUM : " + musteriDurum);

        }

        public void Listele(Musteri[] musteriler ) 
        {           
            
            Console.WriteLine("müsteriler listelendi : ");            

        }

        public void MusteriSilme(Musteri[] musteriler) 
        {
            Console.WriteLine("musteri silindi : ");      
        
        }


    }
}
