using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace Restoran.Database
{
   public class Ponuda
    {
        public int PonudaId { get; set; }
        public int KorisnikId { get; set; }
        public Korisnik Korisnik { get; set; }
        public DateTime DatumPocetka { get; set; }
        public DateTime DatumZavrsetka { get; set; }


    }
}
