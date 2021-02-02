using System;
using System.Collections.Generic;
using System.Text;

namespace Restoran.Model
{
   public class StavkaNarudzbe
    {
        public int StavkaNarudzbeId { get; set; }
        public int? StavkeMenijaId { get; set; }
        public StavkeMenija StavkeMenija { get; set; }
        public int? KombinacijaId { get; set; }
        public Kombinacija Kombinacija { get; set; }
        public int NarudzbaId { get; set; }
  
        public double Cijena { get; set; }
        public int Pdv { get; set; }
        public float Kolicina { get; set; }
        public double CijenaSaPdv { get; set; }

    }
}
