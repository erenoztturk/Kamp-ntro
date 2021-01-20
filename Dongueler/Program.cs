using System;

namespace Dongueler
{
    class Program
    {
        static void Main(string[] args)
        {
           // string kurs1 = "Yazlımı geliştirme kampı";
           // string kurs2 = "Programlamaya başlangıç kursu ";
           // string kurs3 = "Java";

           // Console.WriteLine(kurs1);
           // Console.WriteLine(kurs2);
           // Console.WriteLine(kurs3);

           // array - dizi

            string[] kurslar = new string[] { "Yazlımı geliştirme kampı", "Programlamaya başlangıç kursu ", "Java", "python"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("FOR BİTTİ");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu- footor");
        }
    }
}
