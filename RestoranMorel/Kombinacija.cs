using System;
using System.Collections.Generic;
using System.Text;

namespace Restoran.Model
{
  public  class Kombinacija
    {
        public Kombinacija() {
            StavkeKombinacijes = new HashSet<StavkeKombinacije>();
        }
        public int KombinacijaId { get; set; }
        public int PonudaId { get; set; }
        public Ponuda Ponuda { get; set; }
        public double Cijena { get; set; }
        public float PDV { get; set; }

        public double CijenaSaPdv { get; set; }
        public string Naziv { get; set; }
        public byte[] Slika { get; set; }
        public ICollection<StavkeKombinacije> StavkeKombinacijes { get; set; }


    }
}
