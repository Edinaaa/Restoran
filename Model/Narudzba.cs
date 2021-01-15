using System;
using System.Collections.Generic;
using System.Text;

namespace Restoran.Model
{
   public class Narudzba
    {
    
        public int NarudzbaId { get; set; }
        public DateTime DatumNarudzbe { get; set; }
        public int KorisnikId { get; set; }
        public bool PlacanjeKreditima { get; set; }
        public bool Naplaceno { get; set; }
        public bool Odobrena { get; set; }

        public bool Odbijena { get; set; }
        public bool Naplati { get; set; }
        public double? Cijena { get; set; }
        public double? CijenaSaPdv { get; set; }
        public float? Pdv { get; set; }
        public int BrojStola { get; set; }


    }
}
