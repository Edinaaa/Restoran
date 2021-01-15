using System;
using System.Collections.Generic;
using System.Text;

namespace Restoran.Database
{
   public class Meni
    {
    
        public int MeniId { get; set; }

        public int KorisnikId { get; set; }
        public Korisnik Konobar { get; set; }
        public DateTime DatumObjave { get; set; }
        public bool Vazeci { get; set; }
        public string Naziv { get; set; }


    }
}
