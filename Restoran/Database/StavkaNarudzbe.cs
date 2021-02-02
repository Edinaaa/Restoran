using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Restoran.Database
{
   public class StavkaNarudzbe
    {
        public int StavkaNarudzbeId { get; set; }
        public int? StavkeMenijaId { get; set; }
        public StavkeMenija StavkeMenija { get; set; }
        public int NarudzbaId { get; set; }
        public Narudzba Narudzba { get; set; }
        public int? KombinacijaId { get; set; }
        public Kombinacija Kombinacija { get; set; }
        [Required(ErrorMessage = "Obavezno polje.")]
        public double Cijena { get; set; }
        [Required(ErrorMessage = "Obavezno polje.")]

        public int Pdv { get; set; }
        [Required(ErrorMessage = "Obavezno polje.")]

        public float Kolicina { get; set; }
        [Required(ErrorMessage = "Obavezno polje.")]

        public double CijenaSaPdv { get; set; }


    }
}
