using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace toDoUygulaması
{
    public class silmeIslemi : Veri
    {
        public static void Sil()
        {
            Console.WriteLine("Silmek istediğiniz kartı seçiniz.");
            Console.WriteLine("Lütfen Kart başlığını yazınız:");
            string input = Console.ReadLine();

            foreach (var item in kartlar.ToList())
            {
                if (item.baslik == input)
                {
                    kartlar.Remove(item);
                    break;
                }
                else
                {
                    Console.WriteLine("Aradığınız Kritere Uygun Kart board'da bulunamadı.");
                    Console.WriteLine("* Silmeyi sonlandırmak için (1)");
                    Console.WriteLine("*Yeniden denemek için (2)");
                    int input1 = Convert.ToInt32(Console.ReadLine());

                    if (input1 == 1)
                    {
                        Console.WriteLine("Çıkış yapıldı!");
                        break;
                    }
                    else
                    {
                        Sil();
                    }
                }
            }
        }
    }
}