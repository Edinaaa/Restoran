using Restoran.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranWinUI.Kombinacija
{
   public class StavkeKombinacijeVm
    {
        public int StavkeKombinacijeId { get; set; }
        public int KombinacijaId { get; set; }
        public int ArtikalId { get; set; }
        public Artikal Artikal { get; set; }

        public string Naziv { get; set; }
        public byte[] Slika { get; set; }
        public double Cijena { get; set; }
        public double CijenaSaPdv { get; set; }
        public float PDV { get; set; }
        public float Kolicina { get; set; }
    }
}
