using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace toDoUygulaması
{
    public class eklemeIslemi
    {
        public static void Ekle()
        {
            Kart yeniKart = new Kart();

            Console.WriteLine("Başlık Giriniz: ");
            string input = Console.ReadLine();
            Console.WriteLine("İçerik Giriniz:");
            string input1 = Console.ReadLine();
            Console.WriteLine("Büyüklük Seçiniz XS(1), S(2),M(3), L(4),XL(5)");
            string input2 = Console.ReadLine();
            Console.WriteLine("Atanacak Kişiyi seçiniz:");
            int input3 = Convert.ToInt32(Console.ReadLine());

            yeniKart = new Kart();
            yeniKart.baslik = input;
            yeniKart.icerik = input1;
            if (input2 != null)
            {
                string büyüklükDeğeri = Enum.GetName(typeof(enumSize), input2);
                yeniKart.size = büyüklükDeğeri;
            }

            else
            {
                Console.WriteLine("Geçersiz bir karakter girdiniz.Tekrar deneyiniz.");
                Ekle();
            }

            var kişi = Veri.kisiler.FirstOrDefault(x => x.id == input3);
            if (kişi != null)
            {
                Veri.kartlar.Add(yeniKart);
            }
            else
            {
                Console.WriteLine("Geçeresiz bir sayı girdiniz.");
                Ekle();
            }
        }
    }
}