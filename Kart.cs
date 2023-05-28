using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace toDoUygulaması
{
    public class Kart
    {
        private string Baslik;
        private string Icerik;
        private string Kisi;
        private string Size;
        private string Line;

        public string baslik { get => Baslik; set => Baslik = value; }
        public string icerik { get => Icerik; set => Icerik = value; }
        public string kisi { get => Kisi; set => Kisi = value; }
        public string size { get => Size; set => Size = value; }
        public string line { get => Line; set => Line = value; }

        public Kart(string baslik, string icerik, string kisi, string size, string line)
        {
            Baslik = baslik;
            Icerik = icerik;
            Kisi = kisi;
            Size = size;
            Line = line;

        }
        public Kart()
        {

        }
    }
}