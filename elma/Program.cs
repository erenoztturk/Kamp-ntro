using System;

namespace hangi_gundeyiz

{
    class Program
    {
        static void Main(string[] args)
        {
            int gun = (int)DateTime.Now.DayOfWeek;
            switch (gun)
            {
                case 1:
                    Console.WriteLine("Bugün pazartesi");
                    break;
                case 2:
                    Console.WriteLine("Bugün salı");
                    break;
                case 3:
                    Console.WriteLine("Bugün çarşamba");
                    break;
                case 4:
                    Console.WriteLine("Bugün perşembe");
                    break;
                case 5:
                    Console.WriteLine("Bugün Cuma");
                    break;
                case 6:
                    Console.WriteLine("Bugün Cumartesi");
                    break;
                case 0:
                    Console.WriteLine("bugün pazar");
                    break;
            
            }           
            
        }
    }
}
