using System;

namespace classOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.UrunAdi = "Askılı Hamak";
            urun1.UrunFiyati = 680;
            urun1.UrunMarkasi = "ikea";
            urun1.UrununPuani = 4.3;
            urun1.İndirimOrani = 18;

            Urun urun2 = new Urun();
            urun2.UrunAdi = "Bahçe Oturma Seti";
            urun2.UrunFiyati = 2500;
            urun2.UrunMarkasi = "Bahaus";
            urun2.UrununPuani = 4.5;
            urun2.İndirimOrani = 35;

            Urun urun3 = new Urun();
            urun3.UrunAdi = "Ayaklı Mangal (kömürlü)";
            urun3.UrunFiyati = 280;
            urun3.UrunMarkasi = "Ww grıllstar";
            urun3.UrununPuani = 4.2;
            urun3.İndirimOrani = 15;

            Urun[] urunler = new Urun[] {urun1, urun2, urun3 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.UrunAdi + " : " + urun.UrunFiyati +"tl" + " Marka-> " + urun.UrunMarkasi + " Puan->" + urun.UrununPuani + " İndirim : " + urun.İndirimOrani +
                    "%");
            }

            Console.WriteLine("------------------------");            
            
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].UrunAdi + " : " + urunler[i].UrunFiyati + "tl" + " Marka-> " + urunler[i].UrunMarkasi + " Puan->" + urunler[i].UrununPuani + " İndirim : " +
                    urunler[i].İndirimOrani + "%");
            }

            Console.WriteLine("---------------------");

            int x = 0;
            while (x < urunler.Length )
            {
                Console.WriteLine(urunler[x].UrunAdi + " : " + urunler[x].UrunFiyati + "tl" + " Marka-> " + urunler[x].UrunMarkasi + " Puan->" + urunler[x].UrununPuani + " İndirim : " +
                    urunler[x].İndirimOrani + "%");

                x++;
            }      

            
        }
        

    }

    class Urun
    {
        public string UrunAdi { get; set; }
        public int UrunFiyati { get; set; }
        public string UrunMarkasi { get; set; }
        public double UrununPuani { get; set; }
        public int İndirimOrani { get; set; }


    }
}
