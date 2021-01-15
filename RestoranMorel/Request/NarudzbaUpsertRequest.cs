using System;
using System.Collections.Generic;
using System.Text;

namespace Restoran.Model.Request
{
   public class NarudzbaUpsertRequest
    {
        public DateTime DatumNarudzbe { get; set; }
        public int KorisnikId { get; set; }
        public bool PlacanjeKreditima { get; set; }
        public bool Naplaceno { get; set; }
       
        public int BrojStola { get; set; }

        public List<StavkaNarudzbe> Stavke { get; set; } = new List<StavkaNarudzbe>();
        public string KorisnikUsername { get; set; }
        public string KorisnikPassword { get; set; }


    }
}
