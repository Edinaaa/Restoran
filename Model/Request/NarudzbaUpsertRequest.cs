using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Restoran.Model.Request
{
   public class NarudzbaUpsertRequest
    {
      
        [Range(0, int.MaxValue, ErrorMessage = "Mozete unjeti cijeli broj.")]

        public int KorisnikId { get; set; }
        public bool PlacanjeKreditima { get; set; }
        public bool Naplaceno { get; set; }
        public bool Odobrena { get; set; }
        public bool Odbijena { get; set; }

        public bool Naplati { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Mozete unjeti cijeli broj.")]

        public int BrojStola { get; set; }

        public List<StavkaNarudzbe> Stavke { get; set; } = new List<StavkaNarudzbe>();


    }
}
