using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace toDoUygulaması
{
    internal class Board
    {
        public List<Kart>? ToDo { get; set; }
        public List<Kart>? InProgress { get; set; }
        public List<Kart>? Done { get; set; }
    }
}