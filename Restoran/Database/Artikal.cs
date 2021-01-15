using System;
using System.Collections.Generic;
using System.Text;

namespace Restoran.Database
{
   public class Artikal
    {
      
        public int ArtikalId { get; set; }
        public string Naziv { get; set; }
        public double Cijena { get; set; }
        public int Popust { get; set; }
        public int PDV { get; set; }
        public string Sastav { get; set; }
        public byte[] Slika { get; set; }
        public double CijenaSaPdv { get; set; }
        public int KategorijaId { get; set; }
        public Kategorija Kategorija { get; set; }
        public int JedinicaMjereId { get; set; }
        public JedinicaMjere JedinicaMjere { get; set; }
        public float Kolicina { get; set; }



    }
}
