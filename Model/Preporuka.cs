using System;
using System.Collections.Generic;
using System.Text;

namespace Restoran.Model
{
  public class Preporuka
    {
        public int? StavkeMenijaId { get; set; }
        public int? KombinacijaId { get; set; }
        public int brojNarudzbi { get; set; } = 0;
        public string Naziv { get; set; }
        public double Cijena { get; set; }
        public double Popust { get; set; }
        public int PDV { get; set; }
        public string Sastav { get; set; }
        public byte[] Slika { get; set; }

        public double CijenaSaPdv { get; set; }
    }
}
