
using System;
using System.Collections.Generic;
using System.Text;

namespace Restoran.Model
{
  public  class StavkeMenija
    {
        public int StavkeMenijaId { get; set; }
        public int MeniId { get; set; }
        public int ArtikalId { get; set; }
        public Artikal Artikal { get; set; }
        public int Popust { get; set; }
        public double Cijena { get; set; }
        public double CijenaSaPDV { get; set; }
        public int PDV { get; set; }
        public bool Aktivan { get; set; }


        public int KategorijaId { get; set; }
        public Kategorija Kategorija { get; set; }
    }
}
