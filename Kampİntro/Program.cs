using System;

namespace Kampİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety = tip guvenligi 
            // do not rpeat yourself = kendini tekrarlama 
            // deger tutucu, alias - takma ad
            
            string kategoriEtiketi = " KATEGORİ ";
            int ogrenciSayisi = 3200;
            double faizOrani = 1.45;
            bool sistemeGirisYapmısMi = false;
            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if (dolarDun < dolarBugun)
            {
                Console.WriteLine("artış  oku ");
            }
            else if (dolarDun > dolarBugun)
            {
                Console.WriteLine("azalış oku ");
            }
            else
            {
                Console.WriteLine("eşittir oku ");

            }

            if (sistemeGirisYapmısMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine(" Kayıt Ol ! ");

            }



            Console.WriteLine(kategoriEtiketi);
            
     

        }
    }
}
