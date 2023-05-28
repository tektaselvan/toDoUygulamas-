using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace toDoUygulaması
{
    public class ListelemeIslemi
    {
        private static Board boards;
        public static void LineBoard()
        {
            var todo = Veri.kartlar.Where(x => x.line == "ToDo").ToList();
            var inprogress = Veri.kartlar.Where(x => x.line == "InProgress").ToList();
            var done = Veri.kartlar.Where(x => x.line == "Done").ToList();

            boards = new Board();
            boards.ToDo = todo;
            boards.InProgress = inprogress;
            boards.Done = done;
        }

        public static void Listele()
        {
            LineBoard();
            KartDuzeni.KartGoster("ToDo Line", boards.ToDo);
            KartDuzeni.KartGoster("Inprogress Line", boards.InProgress);
            KartDuzeni.KartGoster("Done Line", boards.Done);
        }
    }
}