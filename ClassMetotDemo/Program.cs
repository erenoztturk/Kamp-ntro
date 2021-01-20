using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = " Eren ";
            musteri1.Yasi = 20;
            musteri1.Memleketi = " Sinop ";
            musteri1.Durum = " Bekar ";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = " Deniz ";
            musteri2.Yasi = 20;
            musteri2.Memleketi = " Sinop";
            musteri2.Durum = " Bekar ";


            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = " Asil ";
            musteri3.Yasi = 20;
            musteri3.Memleketi = " Sinop ";
            musteri3.Durum = " Bekar ";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();
            
            musteriManager.Ekle( " Eren Öztürk ",1, 20, " Sinop (Erfelek) ", " Bekar " );
            musteriManager.Ekle(" Asil Onur Özcan ", 31, 20, "Sinop (Merkez) ", " Bekar ");
            musteriManager.Ekle(" Denizcan Aşkın ", 69, 20, "Sinop (Ayancık) ", " Bekar ");

            Console.WriteLine();

            musteriManager.Listele(musteriler);

            Console.WriteLine(musteri1.Adi);
            Console.WriteLine(musteri2.Adi);
            Console.WriteLine(musteri3.Adi);

            musteriManager.MusteriSilme(musteriler);
            
            Console.WriteLine(musteri1.Adi);

        }
    }
}
