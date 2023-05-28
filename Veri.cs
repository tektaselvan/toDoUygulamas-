using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace toDoUygulaması
{
    public class Veri : Kart
    {
        public static List<Kart> kartlar = new List<Kart>();
        public static List<Kisi> kisiler = new List<Kisi>();
        static Veri()
        {
            kisiler = new List<Kisi>(){
            new Kisi{ id= 1, isim = "Elvan"},
            new Kisi{ id= 2, isim = "XXX"},
            new Kisi{ id= 3, isim = "YYY"},
            new Kisi{ id= 4, isim = "ZZZ"}
        };
            kartlar = new List<Kart>()
        {
            new Kart{baslik= "Ödev", icerik= "Test1", kisi = "Elvan",size ="M",line ="TODO"},
            new Kart{baslik= "Ödev2", icerik= "Test2", kisi = "XXX",size ="XL",line ="DONE"},
            new Kart{baslik= "Ödev3", icerik= "Test3", kisi = "YYY",size ="XS",line ="TODO"},
            new Kart{baslik= "Ödev4", icerik= "Test4", kisi = "ZZZ",size ="L",line ="DONE"},

        };
        }
        public static void VeriYaz()
        {
            foreach (var item in kartlar)
            {
                Console.WriteLine(item.baslik + " " + item.icerik + " " + item.kisi + " " + item.size + " " + item.line);
            }
        }
    }

}