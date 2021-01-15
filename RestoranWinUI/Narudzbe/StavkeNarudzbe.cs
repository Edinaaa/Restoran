using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranWinUI.Narudzbe
{
  public  class StavkeNarudzbe
    {
        public int StavkaNarudzbeId { get; set; }
        public byte[] Slika { get; set; }
        public string Naziv { get; set; }
        public int NarudzbaId { get; set; }

        public double Cijena { get; set; }
        public int Pdv { get; set; }
        public float Kolicina { get; set; }
        public double CijenaSaPdv { get; set; }

    }
}
