using System;
using System.Collections.Generic;
using System.Text;

namespace Restoran.Model.Request
{
   public class PonudaUpsertRequest
    {
        public int PonudaId { get; set; }

        public int KorisnikId { get; set; }
        public Korisnik Korisnik { get; set; }
        public DateTime DatumPocetka { get; set; } = DateTime.Now;
        public DateTime DatumZavrsetka { get; set; } = DateTime.Now;
        public List<int> Kombinacije { get; set; }
    }
}
