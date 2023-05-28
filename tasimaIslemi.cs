using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace toDoUygulaması
{
    public class tasimaIslemi : Veri
    {
        public static void Tasi()
        {

            Console.WriteLine("Silmek istediğiniz kartı seçiniz.");
            Console.WriteLine("Lütfen kart başlığını yazınız: ");
            string input = Console.ReadLine();

            foreach (var item in kartlar)
            {
                if (item.baslik == input)
                {

                    Console.WriteLine("Bulunan Kart Bigileri");
                    Console.WriteLine("*******************************");
                    Console.WriteLine("Başlık     : " + item.baslik);
                    Console.WriteLine("İçerik     : " + item.icerik);
                    Console.WriteLine("Atanan Kişi: " + item.kisi);
                    Console.WriteLine("Büyüklük   : " + item.size);
                    Console.WriteLine("Line       : " + item.line);
                    Console.WriteLine();
                    Console.WriteLine("Lütfen taşıman istediğiniz Line'ı seçiniz:");
                    Console.WriteLine("(1) TODO");
                    Console.WriteLine("(2) INPROGRESS");
                    Console.WriteLine("(3) DONE");
                    int input1 = Convert.ToInt32(Console.ReadLine());

                    switch (input1)
                    {
                        case 1:
                            item.line = "TODO";
                            break;
                        case 2:
                            item.line = "INPROGRESS";
                            break;
                        case 3:
                            item.line = "DONE";
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Hatalı bir tuşlama yaptınız.");
                    break;
                }
            }
        }
    }
}