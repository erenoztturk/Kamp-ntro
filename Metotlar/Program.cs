using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "elma";
            double fiyat = 15;
            string aciklamasi = "amasya elması ";

            Urun urun1 = new Urun();
            urun1.Adi = " elma ";
            urun1.Fiyat = 15;
            urun1.Aciklama = "amasya elması ";

            Urun urun2 = new Urun();
            urun2.Adi = " karpuz ";
            urun2.Fiyat = 80;
            urun2.Aciklama = " diyarbakır karpuzu ";

            Urun[] urunler = new Urun[] {urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyat);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("--------------");
            }

            Console.WriteLine("------------METODLAR-------------");

            //İNSTANCE 
            SepetManeger sepetManager = new SepetManeger();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("armut", "yeşil armut", 12, 10);
            sepetManager.Ekle2("elma", "yeşil elma", 120, 9);
            sepetManager.Ekle2("karpuz", "diyarbakır karpuzu", 12, 8);

        }
    }
}
