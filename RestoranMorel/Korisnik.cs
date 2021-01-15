using System;
using System.Collections.Generic;
using System.Text;

namespace Restoran.Model
{
    public class Korisnik
    {
    
        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Spol { get; set; }
        public DateTime DatumRodenja { get; set; }
        public DateTime? DatumZaposljavanja { get; set; }

        public string KorisnickoIme { get; set; }
        public double IznosKredita { get; set; }

        public byte[] Slika { get; set; }







    }
}
