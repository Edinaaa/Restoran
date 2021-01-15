using System;
using System.Collections.Generic;
using System.Text;

namespace Restoran.Model.Request
{
  public  class ArtikalUpsertRequest
    {

        public string Naziv { get; set; }
        public double Cijena { get; set; }
        public double Popust { get; set; }
        public float PDV { get; set; }
        public string Sastav { get; set; }
        public double CijenaSaPdv { get; set; }
        public int JedinicaMjereId { get; set; }
        public int KategorijaId { get; set; }

        public float Kolicina { get; set; }
        public byte[] Slika { get; set; }
    }
}
