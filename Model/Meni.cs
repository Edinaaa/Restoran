using System;
using System.Collections.Generic;
using System.Text;

namespace Restoran.Model
{
   public class Meni
    {
        public Meni() {
        
        }
        public int MeniId { get; set; }

        public int KorisnikId { get; set; }
        public DateTime DatumObjave { get; set; }
        public bool Vazeci { get; set; }
        public string Naziv { get; set; }

    }
}
