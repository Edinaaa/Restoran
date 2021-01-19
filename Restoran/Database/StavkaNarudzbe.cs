using System;
using System.Collections.Generic;
using System.Text;

namespace Restoran.Database
{
   public class StavkaNarudzbe
    {
        public int StavkaNarudzbeId { get; set; }
        public int? StavkeMenijaId { get; set; }
        public StavkeMenija StavkeMenia { get; set; }
        public int NarudzbaId { get; set; }
        public Narudzba Narudzba { get; set; }
        public int? KombinacijaId { get; set; }
        public Kombinacija Kombinacija { get; set; }
        public double Cijena { get; set; }
        public int Pdv { get; set; }
        public float Kolicina { get; set; }
        public double CijenaSaPdv { get; set; }


    }
}
