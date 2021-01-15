using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranWinUI.Ponude
{
   public class PonudaVm
    {
        public int PonudaId { get; set; }
        public string KorisnickoIme { get; set; }
        public DateTime DatumPocetka { get; set; }
        public DateTime DatumZavrsetka { get; set; }
    }
}
