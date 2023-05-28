using System;
using toDoUygulaması;

namespace toDoUygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz: ");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("(1) Board Listelemek ");
            Console.WriteLine("(2) Board'a Kart Ekle ");
            Console.WriteLine("(3) Board'dan Kart Sil ");
            Console.WriteLine("(4) Kart Taşı ");
            int input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    ListelemeIslemi.Listele();
                    break;
                case 2:
                    eklemeIslemi.Ekle();
                    break;
                case 3:
                    silmeIslemi.Sil();
                    break;
                case 4:
                    tasimaIslemi.Tasi();
                    break;
                default:
                    Console.WriteLine("Hatalı Tuşlama Yaptınız.");
                    break;

            }
        }
    }
}
