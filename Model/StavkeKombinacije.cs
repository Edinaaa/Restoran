using System;
using System.Collections.Generic;
using System.Text;

namespace Restoran.Model
{
  public  class StavkeKombinacije
    {
        public int StavkeKombinacijeId { get; set; }
        public int KombinacijaId { get; set; }
        public int ArtikalId { get; set; }
        public Artikal Artikal { get; set; }
        public float Kolicina { get; set; }
    }
}
