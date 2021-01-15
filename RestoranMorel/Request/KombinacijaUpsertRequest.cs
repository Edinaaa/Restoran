using System;
using System.Collections.Generic;
using System.Text;

namespace Restoran.Model.Request
{
   public class KombinacijaUpsertRequest
    {
        public int KombinacijaId { get; set; }
        public int PonudaId { get; set; }
        public double Cijena { get; set; }
        public float PDV { get; set; }

        public double CijenaSaPdv { get; set; }
        public string Naziv { get; set; }
        public byte[] Slika { get; set; }
        public List<StavkeKombinacije> Stavke { get; set; }
    }
}
