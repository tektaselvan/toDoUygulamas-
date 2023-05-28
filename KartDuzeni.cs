using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace toDoUygulaması
{
    public class KartDuzeni
    {
        static public void KartGoster(string Line, List<Kart> listeismi)
        {
            Console.WriteLine("********** Line **********");
            Console.WriteLine("**************************");
            foreach (var item in listeismi)
            {
                Console.WriteLine("Başlık      :" + item.baslik);
                Console.WriteLine("İçerik      :" + item.icerik);
                Console.WriteLine("Atanan Kişi :" + item.kisi);
                Console.WriteLine("Büyüklük    :" + item.size);
                Console.WriteLine("**************************");
            }
        }
    }
}