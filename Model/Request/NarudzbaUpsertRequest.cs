using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Restoran.Model.Request
{
   public class NarudzbaUpsertRequest
    {
      
        

        public int KorisnikId { get; set; }
        public bool PlacanjeKreditima { get; set; }
        public bool Naplaceno { get; set; }
        public bool Odobrena { get; set; }
        public bool Odbijena { get; set; }

        public bool Naplati { get; set; }
      

        public int BrojStola { get; set; }

        public List<StavkaNarudzbe> Stavke { get; set; } = new List<StavkaNarudzbe>();


    }
}
